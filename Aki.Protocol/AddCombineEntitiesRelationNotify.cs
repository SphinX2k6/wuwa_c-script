using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200009F RID: 159
	[NetMessage(EMessageId.AddCombineEntitiesRelationNotify)]
	public sealed class AddCombineEntitiesRelationNotify : IMessage<AddCombineEntitiesRelationNotify>, IMessage, IEquatable<AddCombineEntitiesRelationNotify>, IDeepCloneable<AddCombineEntitiesRelationNotify>, IBufferMessage
	{
		// Token: 0x06001C2B RID: 7211 RVA: 0x0004E41D File Offset: 0x0004C61D
		[NullableContext(1)]
		public static AddCombineEntitiesRelationNotify Create()
		{
			return new AddCombineEntitiesRelationNotify();
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x0004E424 File Offset: 0x0004C624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x0004E427 File Offset: 0x0004C627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddCombineEntitiesRelationNotify.Descriptor;
			}
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0004E42E File Offset: 0x0004C62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCombineEntitiesRelationNotify()
		{
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0004E438 File Offset: 0x0004C638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCombineEntitiesRelationNotify(AddCombineEntitiesRelationNotify other) : this()
		{
			this.combinePartInfo_ = ((other.combinePartInfo_ != null) ? other.combinePartInfo_.Clone() : null);
			this.targetEntity_ = other.targetEntity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0004E484 File Offset: 0x0004C684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddCombineEntitiesRelationNotify Clone()
		{
			return new AddCombineEntitiesRelationNotify(this);
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x0004E48C File Offset: 0x0004C68C
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0004E494 File Offset: 0x0004C694
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

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x0004E49D File Offset: 0x0004C69D
		// (set) Token: 0x06001C34 RID: 7220 RVA: 0x0004E4A5 File Offset: 0x0004C6A5
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

		// Token: 0x06001C35 RID: 7221 RVA: 0x0004E4AE File Offset: 0x0004C6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddCombineEntitiesRelationNotify);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0004E4BC File Offset: 0x0004C6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddCombineEntitiesRelationNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombinePartInfo, other.CombinePartInfo) && this.TargetEntity == other.TargetEntity && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x0004E50C File Offset: 0x0004C70C
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

		// Token: 0x06001C38 RID: 7224 RVA: 0x0004E561 File Offset: 0x0004C761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x0004E56E File Offset: 0x0004C76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x0004E578 File Offset: 0x0004C778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetEntity != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.TargetEntity);
			}
			if (this.combinePartInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CombinePartInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0004E5D4 File Offset: 0x0004C7D4
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

		// Token: 0x06001C3C RID: 7228 RVA: 0x0004E62C File Offset: 0x0004C82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddCombineEntitiesRelationNotify other)
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

		// Token: 0x06001C3D RID: 7229 RVA: 0x0004E694 File Offset: 0x0004C894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0004E6A0 File Offset: 0x0004C8A0
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
				if (num != 64U)
				{
					if (num != 82U)
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

		// Token: 0x040022CA RID: 8906
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022CB RID: 8907
		public const int CombinePartInfoFieldNumber = 10;

		// Token: 0x040022CC RID: 8908
		private CombinePartInfo combinePartInfo_;

		// Token: 0x040022CD RID: 8909
		public const int TargetEntityFieldNumber = 8;

		// Token: 0x040022CE RID: 8910
		private long targetEntity_;
	}
}
