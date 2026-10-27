using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000687 RID: 1671
	public sealed class GachaAccumulateInfo : IMessage<GachaAccumulateInfo>, IMessage, IEquatable<GachaAccumulateInfo>, IDeepCloneable<GachaAccumulateInfo>, IBufferMessage
	{
		// Token: 0x060098FB RID: 39163 RVA: 0x0017082E File Offset: 0x0016EA2E
		[NullableContext(1)]
		public static GachaAccumulateInfo Create()
		{
			return new GachaAccumulateInfo();
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x060098FC RID: 39164 RVA: 0x00170835 File Offset: 0x0016EA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x060098FD RID: 39165 RVA: 0x00170838 File Offset: 0x0016EA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateInfo.Descriptor;
			}
		}

		// Token: 0x060098FE RID: 39166 RVA: 0x0017083F File Offset: 0x0016EA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfo()
		{
		}

		// Token: 0x060098FF RID: 39167 RVA: 0x00170848 File Offset: 0x0016EA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfo(GachaAccumulateInfo other) : this()
		{
			this.gachaAccumulateId_ = other.gachaAccumulateId_;
			this.gachaAccumulateGroupInfo_ = ((other.gachaAccumulateGroupInfo_ != null) ? other.gachaAccumulateGroupInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009900 RID: 39168 RVA: 0x00170894 File Offset: 0x0016EA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfo Clone()
		{
			return new GachaAccumulateInfo(this);
		}

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x06009901 RID: 39169 RVA: 0x0017089C File Offset: 0x0016EA9C
		// (set) Token: 0x06009902 RID: 39170 RVA: 0x001708A4 File Offset: 0x0016EAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaAccumulateId
		{
			get
			{
				return this.gachaAccumulateId_;
			}
			set
			{
				this.gachaAccumulateId_ = value;
			}
		}

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x06009903 RID: 39171 RVA: 0x001708AD File Offset: 0x0016EAAD
		// (set) Token: 0x06009904 RID: 39172 RVA: 0x001708B5 File Offset: 0x0016EAB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateGroupInfo GachaAccumulateGroupInfo
		{
			get
			{
				return this.gachaAccumulateGroupInfo_;
			}
			set
			{
				this.gachaAccumulateGroupInfo_ = value;
			}
		}

		// Token: 0x06009905 RID: 39173 RVA: 0x001708BE File Offset: 0x0016EABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateInfo);
		}

		// Token: 0x06009906 RID: 39174 RVA: 0x001708CC File Offset: 0x0016EACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateInfo other)
		{
			return other != null && (other == this || (this.GachaAccumulateId == other.GachaAccumulateId && object.Equals(this.GachaAccumulateGroupInfo, other.GachaAccumulateGroupInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009907 RID: 39175 RVA: 0x0017091C File Offset: 0x0016EB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaAccumulateId != 0)
			{
				num ^= this.GachaAccumulateId.GetHashCode();
			}
			if (this.gachaAccumulateGroupInfo_ != null)
			{
				num ^= this.GachaAccumulateGroupInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009908 RID: 39176 RVA: 0x00170971 File Offset: 0x0016EB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009909 RID: 39177 RVA: 0x0017097E File Offset: 0x0016EB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600990A RID: 39178 RVA: 0x00170988 File Offset: 0x0016EB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaAccumulateId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GachaAccumulateId);
			}
			if (this.gachaAccumulateGroupInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GachaAccumulateGroupInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600990B RID: 39179 RVA: 0x001709E0 File Offset: 0x0016EBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaAccumulateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaAccumulateId);
			}
			if (this.gachaAccumulateGroupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaAccumulateGroupInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600990C RID: 39180 RVA: 0x00170A38 File Offset: 0x0016EC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaAccumulateId != 0)
			{
				this.GachaAccumulateId = other.GachaAccumulateId;
			}
			if (other.gachaAccumulateGroupInfo_ != null)
			{
				if (this.gachaAccumulateGroupInfo_ == null)
				{
					this.GachaAccumulateGroupInfo = new GachaAccumulateGroupInfo();
				}
				this.GachaAccumulateGroupInfo.MergeFrom(other.GachaAccumulateGroupInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600990D RID: 39181 RVA: 0x00170AA0 File Offset: 0x0016ECA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600990E RID: 39182 RVA: 0x00170AAC File Offset: 0x0016ECAC
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.gachaAccumulateGroupInfo_ == null)
						{
							this.GachaAccumulateGroupInfo = new GachaAccumulateGroupInfo();
						}
						input.ReadMessage(this.GachaAccumulateGroupInfo);
					}
				}
				else
				{
					this.GachaAccumulateId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400486F RID: 18543
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004870 RID: 18544
		public const int GachaAccumulateIdFieldNumber = 1;

		// Token: 0x04004871 RID: 18545
		private int gachaAccumulateId_;

		// Token: 0x04004872 RID: 18546
		public const int GachaAccumulateGroupInfoFieldNumber = 2;

		// Token: 0x04004873 RID: 18547
		private GachaAccumulateGroupInfo gachaAccumulateGroupInfo_;
	}
}
