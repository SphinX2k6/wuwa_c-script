using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001530 RID: 5424
	[NetMessage(EMessageId.YuXueModeInfoNotify)]
	public sealed class YuXueModeInfoNotify : IMessage<YuXueModeInfoNotify>, IMessage, IEquatable<YuXueModeInfoNotify>, IDeepCloneable<YuXueModeInfoNotify>, IBufferMessage
	{
		// Token: 0x0601CA84 RID: 117380 RVA: 0x00423181 File Offset: 0x00421381
		[NullableContext(1)]
		public static YuXueModeInfoNotify Create()
		{
			return new YuXueModeInfoNotify();
		}

		// Token: 0x17006099 RID: 24729
		// (get) Token: 0x0601CA85 RID: 117381 RVA: 0x00423188 File Offset: 0x00421388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700609A RID: 24730
		// (get) Token: 0x0601CA86 RID: 117382 RVA: 0x0042318B File Offset: 0x0042138B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return YuXueModeInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601CA87 RID: 117383 RVA: 0x00423192 File Offset: 0x00421392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public YuXueModeInfoNotify()
		{
		}

		// Token: 0x0601CA88 RID: 117384 RVA: 0x004231A5 File Offset: 0x004213A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public YuXueModeInfoNotify(YuXueModeInfoNotify other) : this()
		{
			this.globalSetting_ = other.globalSetting_;
			this.btObjYuXueModeInfos_ = other.btObjYuXueModeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA89 RID: 117385 RVA: 0x004231DB File Offset: 0x004213DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public YuXueModeInfoNotify Clone()
		{
			return new YuXueModeInfoNotify(this);
		}

		// Token: 0x1700609B RID: 24731
		// (get) Token: 0x0601CA8A RID: 117386 RVA: 0x004231E3 File Offset: 0x004213E3
		// (set) Token: 0x0601CA8B RID: 117387 RVA: 0x004231EB File Offset: 0x004213EB
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

		// Token: 0x1700609C RID: 24732
		// (get) Token: 0x0601CA8C RID: 117388 RVA: 0x004231F4 File Offset: 0x004213F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BtObjYuXueModeInfo> BtObjYuXueModeInfos
		{
			get
			{
				return this.btObjYuXueModeInfos_;
			}
		}

		// Token: 0x0601CA8D RID: 117389 RVA: 0x004231FC File Offset: 0x004213FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as YuXueModeInfoNotify);
		}

		// Token: 0x0601CA8E RID: 117390 RVA: 0x0042320C File Offset: 0x0042140C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(YuXueModeInfoNotify other)
		{
			return other != null && (other == this || (this.GlobalSetting == other.GlobalSetting && this.btObjYuXueModeInfos_.Equals(other.btObjYuXueModeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA8F RID: 117391 RVA: 0x0042325C File Offset: 0x0042145C
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

		// Token: 0x0601CA90 RID: 117392 RVA: 0x004232A9 File Offset: 0x004214A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA91 RID: 117393 RVA: 0x004232B6 File Offset: 0x004214B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA92 RID: 117394 RVA: 0x004232C0 File Offset: 0x004214C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.btObjYuXueModeInfos_.WriteTo(ref output, YuXueModeInfoNotify._repeated_btObjYuXueModeInfos_codec);
			if (this.GlobalSetting != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.GlobalSetting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA93 RID: 117395 RVA: 0x00423310 File Offset: 0x00421510
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

		// Token: 0x0601CA94 RID: 117396 RVA: 0x00423364 File Offset: 0x00421564
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

		// Token: 0x0601CA95 RID: 117397 RVA: 0x004233B1 File Offset: 0x004215B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA96 RID: 117398 RVA: 0x004233BC File Offset: 0x004215BC
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
				if (num != 26U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GlobalSetting = input.ReadInt32();
					}
				}
				else
				{
					this.btObjYuXueModeInfos_.AddEntriesFrom(ref input, YuXueModeInfoNotify._repeated_btObjYuXueModeInfos_codec);
				}
			}
		}

		// Token: 0x0400A3C8 RID: 41928
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3C9 RID: 41929
		public const int GlobalSettingFieldNumber = 5;

		// Token: 0x0400A3CA RID: 41930
		private int globalSetting_;

		// Token: 0x0400A3CB RID: 41931
		public const int BtObjYuXueModeInfosFieldNumber = 3;

		// Token: 0x0400A3CC RID: 41932
		private static readonly FieldCodec<BtObjYuXueModeInfo> _repeated_btObjYuXueModeInfos_codec = FieldCodec.ForMessage<BtObjYuXueModeInfo>(26U, BtObjYuXueModeInfo.Parser);

		// Token: 0x0400A3CD RID: 41933
		private readonly RepeatedField<BtObjYuXueModeInfo> btObjYuXueModeInfos_ = new RepeatedField<BtObjYuXueModeInfo>();
	}
}
