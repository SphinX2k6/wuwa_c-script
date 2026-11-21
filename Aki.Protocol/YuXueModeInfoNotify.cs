using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A6 RID: 5542
	[NetMessage(EMessageId.YuXueModeInfoNotify)]
	public sealed class YuXueModeInfoNotify : IMessage<YuXueModeInfoNotify>, IMessage, IEquatable<YuXueModeInfoNotify>, IDeepCloneable<YuXueModeInfoNotify>, IBufferMessage
	{
		// Token: 0x0601D54F RID: 120143 RVA: 0x0043EDA1 File Offset: 0x0043CFA1
		[NullableContext(1)]
		public static YuXueModeInfoNotify Create()
		{
			return new YuXueModeInfoNotify();
		}

		// Token: 0x1700633C RID: 25404
		// (get) Token: 0x0601D550 RID: 120144 RVA: 0x0043EDA8 File Offset: 0x0043CFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700633D RID: 25405
		// (get) Token: 0x0601D551 RID: 120145 RVA: 0x0043EDAB File Offset: 0x0043CFAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return YuXueModeInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601D552 RID: 120146 RVA: 0x0043EDB2 File Offset: 0x0043CFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public YuXueModeInfoNotify()
		{
		}

		// Token: 0x0601D553 RID: 120147 RVA: 0x0043EDC5 File Offset: 0x0043CFC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public YuXueModeInfoNotify(YuXueModeInfoNotify other) : this()
		{
			this.globalSetting_ = other.globalSetting_;
			this.btObjYuXueModeInfos_ = other.btObjYuXueModeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D554 RID: 120148 RVA: 0x0043EDFB File Offset: 0x0043CFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public YuXueModeInfoNotify Clone()
		{
			return new YuXueModeInfoNotify(this);
		}

		// Token: 0x1700633E RID: 25406
		// (get) Token: 0x0601D555 RID: 120149 RVA: 0x0043EE03 File Offset: 0x0043D003
		// (set) Token: 0x0601D556 RID: 120150 RVA: 0x0043EE0B File Offset: 0x0043D00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GlobalSetting
		{
			get
			{
				return this.globalSetting_;
			}
			set
			{
				this.globalSetting_ = value;
			}
		}

		// Token: 0x1700633F RID: 25407
		// (get) Token: 0x0601D557 RID: 120151 RVA: 0x0043EE14 File Offset: 0x0043D014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BtObjYuXueModeInfo> BtObjYuXueModeInfos
		{
			get
			{
				return this.btObjYuXueModeInfos_;
			}
		}

		// Token: 0x0601D558 RID: 120152 RVA: 0x0043EE1C File Offset: 0x0043D01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as YuXueModeInfoNotify);
		}

		// Token: 0x0601D559 RID: 120153 RVA: 0x0043EE2C File Offset: 0x0043D02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(YuXueModeInfoNotify other)
		{
			return other != null && (other == this || (this.GlobalSetting == other.GlobalSetting && this.btObjYuXueModeInfos_.Equals(other.btObjYuXueModeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D55A RID: 120154 RVA: 0x0043EE7C File Offset: 0x0043D07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GlobalSetting != 0)
			{
				num ^= this.GlobalSetting.GetHashCode();
			}
			num ^= this.btObjYuXueModeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D55B RID: 120155 RVA: 0x0043EEC9 File Offset: 0x0043D0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D55C RID: 120156 RVA: 0x0043EED6 File Offset: 0x0043D0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D55D RID: 120157 RVA: 0x0043EEE0 File Offset: 0x0043D0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GlobalSetting != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GlobalSetting);
			}
			this.btObjYuXueModeInfos_.WriteTo(ref output, YuXueModeInfoNotify._repeated_btObjYuXueModeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D55E RID: 120158 RVA: 0x0043EF30 File Offset: 0x0043D130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GlobalSetting != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GlobalSetting);
			}
			num += this.btObjYuXueModeInfos_.CalculateSize(YuXueModeInfoNotify._repeated_btObjYuXueModeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D55F RID: 120159 RVA: 0x0043EF84 File Offset: 0x0043D184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(YuXueModeInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GlobalSetting != 0)
			{
				this.GlobalSetting = other.GlobalSetting;
			}
			this.btObjYuXueModeInfos_.Add(other.btObjYuXueModeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D560 RID: 120160 RVA: 0x0043EFD1 File Offset: 0x0043D1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D561 RID: 120161 RVA: 0x0043EFDC File Offset: 0x0043D1DC
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.btObjYuXueModeInfos_.AddEntriesFrom(ref input, YuXueModeInfoNotify._repeated_btObjYuXueModeInfos_codec);
					}
				}
				else
				{
					this.GlobalSetting = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A825 RID: 43045
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A826 RID: 43046
		public const int GlobalSettingFieldNumber = 1;

		// Token: 0x0400A827 RID: 43047
		private int globalSetting_;

		// Token: 0x0400A828 RID: 43048
		public const int BtObjYuXueModeInfosFieldNumber = 15;

		// Token: 0x0400A829 RID: 43049
		private static readonly FieldCodec<BtObjYuXueModeInfo> _repeated_btObjYuXueModeInfos_codec = FieldCodec.ForMessage<BtObjYuXueModeInfo>(122U, BtObjYuXueModeInfo.Parser);

		// Token: 0x0400A82A RID: 43050
		private readonly RepeatedField<BtObjYuXueModeInfo> btObjYuXueModeInfos_ = new RepeatedField<BtObjYuXueModeInfo>();
	}
}
