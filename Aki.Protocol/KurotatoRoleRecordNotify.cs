using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B7 RID: 2231
	[NetMessage(EMessageId.KurotatoRoleRecordNotify)]
	public sealed class KurotatoRoleRecordNotify : IMessage<KurotatoRoleRecordNotify>, IMessage, IEquatable<KurotatoRoleRecordNotify>, IDeepCloneable<KurotatoRoleRecordNotify>, IBufferMessage
	{
		// Token: 0x0600C5F1 RID: 50673 RVA: 0x001D4AE6 File Offset: 0x001D2CE6
		[NullableContext(1)]
		public static KurotatoRoleRecordNotify Create()
		{
			return new KurotatoRoleRecordNotify();
		}

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x0600C5F2 RID: 50674 RVA: 0x001D4AED File Offset: 0x001D2CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002801 RID: 10241
		// (get) Token: 0x0600C5F3 RID: 50675 RVA: 0x001D4AF0 File Offset: 0x001D2CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRoleRecordNotify.Descriptor;
			}
		}

		// Token: 0x0600C5F4 RID: 50676 RVA: 0x001D4AF7 File Offset: 0x001D2CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordNotify()
		{
		}

		// Token: 0x0600C5F5 RID: 50677 RVA: 0x001D4B0C File Offset: 0x001D2D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordNotify(KurotatoRoleRecordNotify other) : this()
		{
			this.kurotatoRoleSaveState_ = other.kurotatoRoleSaveState_;
			this.isPopView_ = other.isPopView_;
			this.instInfos_ = other.instInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C5F6 RID: 50678 RVA: 0x001D4B59 File Offset: 0x001D2D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordNotify Clone()
		{
			return new KurotatoRoleRecordNotify(this);
		}

		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x0600C5F7 RID: 50679 RVA: 0x001D4B61 File Offset: 0x001D2D61
		// (set) Token: 0x0600C5F8 RID: 50680 RVA: 0x001D4B69 File Offset: 0x001D2D69
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

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x0600C5F9 RID: 50681 RVA: 0x001D4B72 File Offset: 0x001D2D72
		// (set) Token: 0x0600C5FA RID: 50682 RVA: 0x001D4B7A File Offset: 0x001D2D7A
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

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x0600C5FB RID: 50683 RVA: 0x001D4B83 File Offset: 0x001D2D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoInstInfo> InstInfos
		{
			get
			{
				return this.instInfos_;
			}
		}

		// Token: 0x0600C5FC RID: 50684 RVA: 0x001D4B8B File Offset: 0x001D2D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRoleRecordNotify);
		}

		// Token: 0x0600C5FD RID: 50685 RVA: 0x001D4B9C File Offset: 0x001D2D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRoleRecordNotify other)
		{
			return other != null && (other == this || (this.KurotatoRoleSaveState == other.KurotatoRoleSaveState && this.IsPopView == other.IsPopView && this.instInfos_.Equals(other.instInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C5FE RID: 50686 RVA: 0x001D4BFC File Offset: 0x001D2DFC
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

		// Token: 0x0600C5FF RID: 50687 RVA: 0x001D4C68 File Offset: 0x001D2E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C600 RID: 50688 RVA: 0x001D4C75 File Offset: 0x001D2E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C601 RID: 50689 RVA: 0x001D4C80 File Offset: 0x001D2E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instInfos_.WriteTo(ref output, KurotatoRoleRecordNotify._repeated_instInfos_codec);
			if (this.KurotatoRoleSaveState != KurotatoRoleSaveState.Undefine)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.KurotatoRoleSaveState);
			}
			if (this.IsPopView)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsPopView);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C602 RID: 50690 RVA: 0x001D4CEC File Offset: 0x001D2EEC
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

		// Token: 0x0600C603 RID: 50691 RVA: 0x001D4D4C File Offset: 0x001D2F4C
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

		// Token: 0x0600C604 RID: 50692 RVA: 0x001D4DAD File Offset: 0x001D2FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C605 RID: 50693 RVA: 0x001D4DB8 File Offset: 0x001D2FB8
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
				if (num != 34U)
				{
					if (num != 40U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsPopView = input.ReadBool();
						}
					}
					else
					{
						this.KurotatoRoleSaveState = (KurotatoRoleSaveState)input.ReadEnum();
					}
				}
				else
				{
					this.instInfos_.AddEntriesFrom(ref input, KurotatoRoleRecordNotify._repeated_instInfos_codec);
				}
			}
		}

		// Token: 0x04005515 RID: 21781
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005516 RID: 21782
		public const int KurotatoRoleSaveStateFieldNumber = 5;

		// Token: 0x04005517 RID: 21783
		private KurotatoRoleSaveState kurotatoRoleSaveState_;

		// Token: 0x04005518 RID: 21784
		public const int IsPopViewFieldNumber = 11;

		// Token: 0x04005519 RID: 21785
		private bool isPopView_;

		// Token: 0x0400551A RID: 21786
		public const int InstInfosFieldNumber = 4;

		// Token: 0x0400551B RID: 21787
		private static readonly FieldCodec<KurotatoInstInfo> _repeated_instInfos_codec = FieldCodec.ForMessage<KurotatoInstInfo>(34U, KurotatoInstInfo.Parser);

		// Token: 0x0400551C RID: 21788
		private readonly RepeatedField<KurotatoInstInfo> instInfos_ = new RepeatedField<KurotatoInstInfo>();
	}
}
