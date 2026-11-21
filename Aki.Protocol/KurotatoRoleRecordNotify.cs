using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A6 RID: 2214
	[NetMessage(EMessageId.KurotatoRoleRecordNotify)]
	public sealed class KurotatoRoleRecordNotify : IMessage<KurotatoRoleRecordNotify>, IMessage, IEquatable<KurotatoRoleRecordNotify>, IDeepCloneable<KurotatoRoleRecordNotify>, IBufferMessage
	{
		// Token: 0x0600C4D5 RID: 50389 RVA: 0x001D27FE File Offset: 0x001D09FE
		[NullableContext(1)]
		public static KurotatoRoleRecordNotify Create()
		{
			return new KurotatoRoleRecordNotify();
		}

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x0600C4D6 RID: 50390 RVA: 0x001D2805 File Offset: 0x001D0A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x0600C4D7 RID: 50391 RVA: 0x001D2808 File Offset: 0x001D0A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRoleRecordNotify.Descriptor;
			}
		}

		// Token: 0x0600C4D8 RID: 50392 RVA: 0x001D280F File Offset: 0x001D0A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordNotify()
		{
		}

		// Token: 0x0600C4D9 RID: 50393 RVA: 0x001D2824 File Offset: 0x001D0A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordNotify(KurotatoRoleRecordNotify other) : this()
		{
			this.kurotatoRoleSaveState_ = other.kurotatoRoleSaveState_;
			this.isPopView_ = other.isPopView_;
			this.instInfos_ = other.instInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4DA RID: 50394 RVA: 0x001D2871 File Offset: 0x001D0A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordNotify Clone()
		{
			return new KurotatoRoleRecordNotify(this);
		}

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x0600C4DB RID: 50395 RVA: 0x001D2879 File Offset: 0x001D0A79
		// (set) Token: 0x0600C4DC RID: 50396 RVA: 0x001D2881 File Offset: 0x001D0A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleSaveState KurotatoRoleSaveState
		{
			get
			{
				return this.kurotatoRoleSaveState_;
			}
			set
			{
				this.kurotatoRoleSaveState_ = value;
			}
		}

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x0600C4DD RID: 50397 RVA: 0x001D288A File Offset: 0x001D0A8A
		// (set) Token: 0x0600C4DE RID: 50398 RVA: 0x001D2892 File Offset: 0x001D0A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPopView
		{
			get
			{
				return this.isPopView_;
			}
			set
			{
				this.isPopView_ = value;
			}
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x0600C4DF RID: 50399 RVA: 0x001D289B File Offset: 0x001D0A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoInstInfo> InstInfos
		{
			get
			{
				return this.instInfos_;
			}
		}

		// Token: 0x0600C4E0 RID: 50400 RVA: 0x001D28A3 File Offset: 0x001D0AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRoleRecordNotify);
		}

		// Token: 0x0600C4E1 RID: 50401 RVA: 0x001D28B4 File Offset: 0x001D0AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRoleRecordNotify other)
		{
			return other != null && (other == this || (this.KurotatoRoleSaveState == other.KurotatoRoleSaveState && this.IsPopView == other.IsPopView && this.instInfos_.Equals(other.instInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C4E2 RID: 50402 RVA: 0x001D2914 File Offset: 0x001D0B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KurotatoRoleSaveState != KurotatoRoleSaveState.Undefine)
			{
				num ^= this.KurotatoRoleSaveState.GetHashCode();
			}
			if (this.IsPopView)
			{
				num ^= this.IsPopView.GetHashCode();
			}
			num ^= this.instInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C4E3 RID: 50403 RVA: 0x001D2980 File Offset: 0x001D0B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C4E4 RID: 50404 RVA: 0x001D298D File Offset: 0x001D0B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4E5 RID: 50405 RVA: 0x001D2998 File Offset: 0x001D0B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instInfos_.WriteTo(ref output, KurotatoRoleRecordNotify._repeated_instInfos_codec);
			if (this.IsPopView)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsPopView);
			}
			if (this.KurotatoRoleSaveState != KurotatoRoleSaveState.Undefine)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.KurotatoRoleSaveState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C4E6 RID: 50406 RVA: 0x001D2A04 File Offset: 0x001D0C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KurotatoRoleSaveState != KurotatoRoleSaveState.Undefine)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.KurotatoRoleSaveState);
			}
			if (this.IsPopView)
			{
				num += 2;
			}
			num += this.instInfos_.CalculateSize(KurotatoRoleRecordNotify._repeated_instInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C4E7 RID: 50407 RVA: 0x001D2A64 File Offset: 0x001D0C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoRoleRecordNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KurotatoRoleSaveState != KurotatoRoleSaveState.Undefine)
			{
				this.KurotatoRoleSaveState = other.KurotatoRoleSaveState;
			}
			if (other.IsPopView)
			{
				this.IsPopView = other.IsPopView;
			}
			this.instInfos_.Add(other.instInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C4E8 RID: 50408 RVA: 0x001D2AC5 File Offset: 0x001D0CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4E9 RID: 50409 RVA: 0x001D2AD0 File Offset: 0x001D0CD0
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.KurotatoRoleSaveState = (KurotatoRoleSaveState)input.ReadEnum();
						}
					}
					else
					{
						this.IsPopView = input.ReadBool();
					}
				}
				else
				{
					this.instInfos_.AddEntriesFrom(ref input, KurotatoRoleRecordNotify._repeated_instInfos_codec);
				}
			}
		}

		// Token: 0x0400551C RID: 21788
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400551D RID: 21789
		public const int KurotatoRoleSaveStateFieldNumber = 4;

		// Token: 0x0400551E RID: 21790
		private KurotatoRoleSaveState kurotatoRoleSaveState_;

		// Token: 0x0400551F RID: 21791
		public const int IsPopViewFieldNumber = 2;

		// Token: 0x04005520 RID: 21792
		private bool isPopView_;

		// Token: 0x04005521 RID: 21793
		public const int InstInfosFieldNumber = 1;

		// Token: 0x04005522 RID: 21794
		private static readonly FieldCodec<KurotatoInstInfo> _repeated_instInfos_codec = FieldCodec.ForMessage<KurotatoInstInfo>(10U, KurotatoInstInfo.Parser);

		// Token: 0x04005523 RID: 21795
		private readonly RepeatedField<KurotatoInstInfo> instInfos_ = new RepeatedField<KurotatoInstInfo>();
	}
}
