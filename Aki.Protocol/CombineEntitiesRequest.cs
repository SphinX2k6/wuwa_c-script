using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B3 RID: 691
	[NetMessage(EMessageId.CombineEntitiesRequest)]
	public sealed class CombineEntitiesRequest : IMessage<CombineEntitiesRequest>, IMessage, IEquatable<CombineEntitiesRequest>, IDeepCloneable<CombineEntitiesRequest>, IBufferMessage
	{
		// Token: 0x0600477C RID: 18300 RVA: 0x000AF992 File Offset: 0x000ADB92
		[NullableContext(1)]
		public static CombineEntitiesRequest Create()
		{
			return new CombineEntitiesRequest();
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x0600477D RID: 18301 RVA: 0x000AF999 File Offset: 0x000ADB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x0600477E RID: 18302 RVA: 0x000AF99C File Offset: 0x000ADB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombineEntitiesRequest.Descriptor;
			}
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x000AF9A3 File Offset: 0x000ADBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesRequest()
		{
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x000AF9AC File Offset: 0x000ADBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesRequest(CombineEntitiesRequest other) : this()
		{
			this.combinePartInfo_ = ((other.combinePartInfo_ != null) ? other.combinePartInfo_.Clone() : null);
			this.targetEntity_ = other.targetEntity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x000AF9F8 File Offset: 0x000ADBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntitiesRequest Clone()
		{
			return new CombineEntitiesRequest(this);
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06004782 RID: 18306 RVA: 0x000AFA00 File Offset: 0x000ADC00
		// (set) Token: 0x06004783 RID: 18307 RVA: 0x000AFA08 File Offset: 0x000ADC08
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

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x000AFA11 File Offset: 0x000ADC11
		// (set) Token: 0x06004785 RID: 18309 RVA: 0x000AFA19 File Offset: 0x000ADC19
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

		// Token: 0x06004786 RID: 18310 RVA: 0x000AFA22 File Offset: 0x000ADC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombineEntitiesRequest);
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x000AFA30 File Offset: 0x000ADC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombineEntitiesRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombinePartInfo, other.CombinePartInfo) && this.TargetEntity == other.TargetEntity && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x000AFA80 File Offset: 0x000ADC80
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

		// Token: 0x06004789 RID: 18313 RVA: 0x000AFAD5 File Offset: 0x000ADCD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x000AFAE2 File Offset: 0x000ADCE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x000AFAEC File Offset: 0x000ADCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetEntity != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TargetEntity);
			}
			if (this.combinePartInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CombinePartInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x000AFB48 File Offset: 0x000ADD48
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

		// Token: 0x0600478D RID: 18317 RVA: 0x000AFBA0 File Offset: 0x000ADDA0
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

		// Token: 0x0600478E RID: 18318 RVA: 0x000AFC08 File Offset: 0x000ADE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x000AFC14 File Offset: 0x000ADE14
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
				if (num != 40U)
				{
					if (num != 114U)
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

		// Token: 0x04002FA6 RID: 12198
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FA7 RID: 12199
		public const int CombinePartInfoFieldNumber = 14;

		// Token: 0x04002FA8 RID: 12200
		private CombinePartInfo combinePartInfo_;

		// Token: 0x04002FA9 RID: 12201
		public const int TargetEntityFieldNumber = 5;

		// Token: 0x04002FAA RID: 12202
		private long targetEntity_;
	}
}
