using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F5 RID: 757
	[NetMessage(EMessageId.ControlInfoNotify)]
	public sealed class ControlInfoNotify : IMessage<ControlInfoNotify>, IMessage, IEquatable<ControlInfoNotify>, IDeepCloneable<ControlInfoNotify>, IBufferMessage
	{
		// Token: 0x06004CF6 RID: 19702 RVA: 0x000BB855 File Offset: 0x000B9A55
		[NullableContext(1)]
		public static ControlInfoNotify Create()
		{
			return new ControlInfoNotify();
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06004CF7 RID: 19703 RVA: 0x000BB85C File Offset: 0x000B9A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06004CF8 RID: 19704 RVA: 0x000BB85F File Offset: 0x000B9A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ControlInfoNotify.Descriptor;
			}
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x000BB866 File Offset: 0x000B9A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlInfoNotify()
		{
		}

		// Token: 0x06004CFA RID: 19706 RVA: 0x000BB879 File Offset: 0x000B9A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlInfoNotify(ControlInfoNotify other) : this()
		{
			this.forbidList_ = other.forbidList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x000BB8A3 File Offset: 0x000B9AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlInfoNotify Clone()
		{
			return new ControlInfoNotify(this);
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06004CFC RID: 19708 RVA: 0x000BB8AB File Offset: 0x000B9AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ControlParam> ForbidList
		{
			get
			{
				return this.forbidList_;
			}
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x000BB8B3 File Offset: 0x000B9AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ControlInfoNotify);
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x000BB8C1 File Offset: 0x000B9AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ControlInfoNotify other)
		{
			return other != null && (other == this || (this.forbidList_.Equals(other.forbidList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x000BB8F4 File Offset: 0x000B9AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.forbidList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x000BB928 File Offset: 0x000B9B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x000BB935 File Offset: 0x000B9B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x000BB93E File Offset: 0x000B9B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.forbidList_.WriteTo(ref output, ControlInfoNotify._repeated_forbidList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x000BB968 File Offset: 0x000B9B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.forbidList_.CalculateSize(ControlInfoNotify._repeated_forbidList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x000BB9A1 File Offset: 0x000B9BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ControlInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.forbidList_.Add(other.forbidList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x000BB9CF File Offset: 0x000B9BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x000BB9D8 File Offset: 0x000B9BD8
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.forbidList_.AddEntriesFrom(ref input, ControlInfoNotify._repeated_forbidList_codec);
				}
			}
		}

		// Token: 0x04003179 RID: 12665
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400317A RID: 12666
		public const int ForbidListFieldNumber = 2;

		// Token: 0x0400317B RID: 12667
		private static readonly FieldCodec<ControlParam> _repeated_forbidList_codec = FieldCodec.ForMessage<ControlParam>(18U, ControlParam.Parser);

		// Token: 0x0400317C RID: 12668
		private readonly RepeatedField<ControlParam> forbidList_ = new RepeatedField<ControlParam>();
	}
}
