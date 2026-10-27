using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D1 RID: 209
	[NetMessage(EMessageId.AdviceSettingNotify)]
	public sealed class AdviceSettingNotify : IMessage<AdviceSettingNotify>, IMessage, IEquatable<AdviceSettingNotify>, IDeepCloneable<AdviceSettingNotify>, IBufferMessage
	{
		// Token: 0x06002012 RID: 8210 RVA: 0x00056C2B File Offset: 0x00054E2B
		[NullableContext(1)]
		public static AdviceSettingNotify Create()
		{
			return new AdviceSettingNotify();
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x00056C32 File Offset: 0x00054E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x00056C35 File Offset: 0x00054E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceSettingNotify.Descriptor;
			}
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00056C3C File Offset: 0x00054E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSettingNotify()
		{
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00056C44 File Offset: 0x00054E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSettingNotify(AdviceSettingNotify other) : this()
		{
			this.isShow_ = other.isShow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x00056C69 File Offset: 0x00054E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSettingNotify Clone()
		{
			return new AdviceSettingNotify(this);
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x00056C71 File Offset: 0x00054E71
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x00056C79 File Offset: 0x00054E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00056C82 File Offset: 0x00054E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceSettingNotify);
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00056C90 File Offset: 0x00054E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceSettingNotify other)
		{
			return other != null && (other == this || (this.IsShow == other.IsShow && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00056CC0 File Offset: 0x00054EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00056CFF File Offset: 0x00054EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00056D0C File Offset: 0x00054F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00056D15 File Offset: 0x00054F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShow)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsShow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00056D48 File Offset: 0x00054F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsShow)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00056D7A File Offset: 0x00054F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceSettingNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00056DAB File Offset: 0x00054FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00056DB4 File Offset: 0x00054FB4
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsShow = input.ReadBool();
				}
			}
		}

		// Token: 0x040023E1 RID: 9185
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023E2 RID: 9186
		public const int IsShowFieldNumber = 12;

		// Token: 0x040023E3 RID: 9187
		private bool isShow_;
	}
}
