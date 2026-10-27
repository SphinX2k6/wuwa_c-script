using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001425 RID: 5157
	[NetMessage(EMessageId.TrapDefenseGainingGroupUpdateNotify)]
	public sealed class TrapDefenseGainingGroupUpdateNotify : IMessage<TrapDefenseGainingGroupUpdateNotify>, IMessage, IEquatable<TrapDefenseGainingGroupUpdateNotify>, IDeepCloneable<TrapDefenseGainingGroupUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B547 RID: 111943 RVA: 0x003F5A38 File Offset: 0x003F3C38
		[NullableContext(1)]
		public static TrapDefenseGainingGroupUpdateNotify Create()
		{
			return new TrapDefenseGainingGroupUpdateNotify();
		}

		// Token: 0x17005C2E RID: 23598
		// (get) Token: 0x0601B548 RID: 111944 RVA: 0x003F5A3F File Offset: 0x003F3C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C2F RID: 23599
		// (get) Token: 0x0601B549 RID: 111945 RVA: 0x003F5A42 File Offset: 0x003F3C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGainingGroupUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B54A RID: 111946 RVA: 0x003F5A49 File Offset: 0x003F3C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingGroupUpdateNotify()
		{
		}

		// Token: 0x0601B54B RID: 111947 RVA: 0x003F5A54 File Offset: 0x003F3C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingGroupUpdateNotify(TrapDefenseGainingGroupUpdateNotify other) : this()
		{
			this.gainingGroupInfo_ = ((other.gainingGroupInfo_ != null) ? other.gainingGroupInfo_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B54C RID: 111948 RVA: 0x003F5AA0 File Offset: 0x003F3CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingGroupUpdateNotify Clone()
		{
			return new TrapDefenseGainingGroupUpdateNotify(this);
		}

		// Token: 0x17005C30 RID: 23600
		// (get) Token: 0x0601B54D RID: 111949 RVA: 0x003F5AA8 File Offset: 0x003F3CA8
		// (set) Token: 0x0601B54E RID: 111950 RVA: 0x003F5AB0 File Offset: 0x003F3CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingInfo GainingGroupInfo
		{
			get
			{
				return this.gainingGroupInfo_;
			}
			set
			{
				this.gainingGroupInfo_ = value;
			}
		}

		// Token: 0x17005C31 RID: 23601
		// (get) Token: 0x0601B54F RID: 111951 RVA: 0x003F5AB9 File Offset: 0x003F3CB9
		// (set) Token: 0x0601B550 RID: 111952 RVA: 0x003F5AC1 File Offset: 0x003F3CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingUpdateReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0601B551 RID: 111953 RVA: 0x003F5ACA File Offset: 0x003F3CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGainingGroupUpdateNotify);
		}

		// Token: 0x0601B552 RID: 111954 RVA: 0x003F5AD8 File Offset: 0x003F3CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGainingGroupUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GainingGroupInfo, other.GainingGroupInfo) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B553 RID: 111955 RVA: 0x003F5B28 File Offset: 0x003F3D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gainingGroupInfo_ != null)
			{
				num ^= this.GainingGroupInfo.GetHashCode();
			}
			if (this.Reason != TrapDefenseGainingUpdateReason.GmaddGroup)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B554 RID: 111956 RVA: 0x003F5B83 File Offset: 0x003F3D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B555 RID: 111957 RVA: 0x003F5B90 File Offset: 0x003F3D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B556 RID: 111958 RVA: 0x003F5B9C File Offset: 0x003F3D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gainingGroupInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.GainingGroupInfo);
			}
			if (this.Reason != TrapDefenseGainingUpdateReason.GmaddGroup)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B557 RID: 111959 RVA: 0x003F5BF8 File Offset: 0x003F3DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gainingGroupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GainingGroupInfo);
			}
			if (this.Reason != TrapDefenseGainingUpdateReason.GmaddGroup)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B558 RID: 111960 RVA: 0x003F5C50 File Offset: 0x003F3E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGainingGroupUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gainingGroupInfo_ != null)
			{
				if (this.gainingGroupInfo_ == null)
				{
					this.GainingGroupInfo = new TrapDefenseGainingInfo();
				}
				this.GainingGroupInfo.MergeFrom(other.GainingGroupInfo);
			}
			if (other.Reason != TrapDefenseGainingUpdateReason.GmaddGroup)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B559 RID: 111961 RVA: 0x003F5CB8 File Offset: 0x003F3EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B55A RID: 111962 RVA: 0x003F5CC4 File Offset: 0x003F3EC4
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
				if (num != 98U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reason = (TrapDefenseGainingUpdateReason)input.ReadEnum();
					}
				}
				else
				{
					if (this.gainingGroupInfo_ == null)
					{
						this.GainingGroupInfo = new TrapDefenseGainingInfo();
					}
					input.ReadMessage(this.GainingGroupInfo);
				}
			}
		}

		// Token: 0x04009DEA RID: 40426
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DEB RID: 40427
		public const int GainingGroupInfoFieldNumber = 12;

		// Token: 0x04009DEC RID: 40428
		private TrapDefenseGainingInfo gainingGroupInfo_;

		// Token: 0x04009DED RID: 40429
		public const int ReasonFieldNumber = 15;

		// Token: 0x04009DEE RID: 40430
		private TrapDefenseGainingUpdateReason reason_;
	}
}
