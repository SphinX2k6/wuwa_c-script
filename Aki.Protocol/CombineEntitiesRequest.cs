using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B9 RID: 697
	[NetMessage(EMessageId.CombineEntitiesRequest)]
	public sealed class CombineEntitiesRequest : IMessage<CombineEntitiesRequest>, IMessage, IEquatable<CombineEntitiesRequest>, IDeepCloneable<CombineEntitiesRequest>, IBufferMessage
	{
		// Token: 0x06004843 RID: 18499 RVA: 0x000B1B96 File Offset: 0x000AFD96
		[NullableContext(1)]
		public static CombineEntitiesRequest Create()
		{
			return new CombineEntitiesRequest();
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06004844 RID: 18500 RVA: 0x000B1B9D File Offset: 0x000AFD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06004845 RID: 18501 RVA: 0x000B1BA0 File Offset: 0x000AFDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombineEntitiesRequest.Descriptor;
			}
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x000B1BA7 File Offset: 0x000AFDA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesRequest()
		{
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x000B1BB0 File Offset: 0x000AFDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesRequest(CombineEntitiesRequest other) : this()
		{
			this.combinePartInfo_ = ((other.combinePartInfo_ != null) ? other.combinePartInfo_.Clone() : null);
			this.targetEntity_ = other.targetEntity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x000B1BFC File Offset: 0x000AFDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesRequest Clone()
		{
			return new CombineEntitiesRequest(this);
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06004849 RID: 18505 RVA: 0x000B1C04 File Offset: 0x000AFE04
		// (set) Token: 0x0600484A RID: 18506 RVA: 0x000B1C0C File Offset: 0x000AFE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinePartInfo CombinePartInfo
		{
			get
			{
				return this.combinePartInfo_;
			}
			set
			{
				this.combinePartInfo_ = value;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x000B1C15 File Offset: 0x000AFE15
		// (set) Token: 0x0600484C RID: 18508 RVA: 0x000B1C1D File Offset: 0x000AFE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntity
		{
			get
			{
				return this.targetEntity_;
			}
			set
			{
				this.targetEntity_ = value;
			}
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x000B1C26 File Offset: 0x000AFE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombineEntitiesRequest);
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x000B1C34 File Offset: 0x000AFE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombineEntitiesRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombinePartInfo, other.CombinePartInfo) && this.TargetEntity == other.TargetEntity && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x000B1C84 File Offset: 0x000AFE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combinePartInfo_ != null)
			{
				num ^= this.CombinePartInfo.GetHashCode();
			}
			if (this.TargetEntity != 0L)
			{
				num ^= this.TargetEntity.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x000B1CD9 File Offset: 0x000AFED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x000B1CE6 File Offset: 0x000AFEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x000B1CF0 File Offset: 0x000AFEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetEntity != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.TargetEntity);
			}
			if (this.combinePartInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CombinePartInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004853 RID: 18515 RVA: 0x000B1D4C File Offset: 0x000AFF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combinePartInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombinePartInfo);
			}
			if (this.TargetEntity != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntity);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x000B1DA4 File Offset: 0x000AFFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombineEntitiesRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combinePartInfo_ != null)
			{
				if (this.combinePartInfo_ == null)
				{
					this.CombinePartInfo = new CombinePartInfo();
				}
				this.CombinePartInfo.MergeFrom(other.CombinePartInfo);
			}
			if (other.TargetEntity != 0L)
			{
				this.TargetEntity = other.TargetEntity;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x000B1E0C File Offset: 0x000B000C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004856 RID: 18518 RVA: 0x000B1E18 File Offset: 0x000B0018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 24U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.combinePartInfo_ == null)
						{
							this.CombinePartInfo = new CombinePartInfo();
						}
						input.ReadMessage(this.CombinePartInfo);
					}
				}
				else
				{
					this.TargetEntity = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003039 RID: 12345
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400303A RID: 12346
		public const int CombinePartInfoFieldNumber = 8;

		// Token: 0x0400303B RID: 12347
		private CombinePartInfo combinePartInfo_;

		// Token: 0x0400303C RID: 12348
		public const int TargetEntityFieldNumber = 3;

		// Token: 0x0400303D RID: 12349
		private long targetEntity_;
	}
}
