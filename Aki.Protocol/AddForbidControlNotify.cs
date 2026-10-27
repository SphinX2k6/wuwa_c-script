using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A4 RID: 164
	[NetMessage(EMessageId.AddForbidControlNotify)]
	public sealed class AddForbidControlNotify : IMessage<AddForbidControlNotify>, IMessage, IEquatable<AddForbidControlNotify>, IDeepCloneable<AddForbidControlNotify>, IBufferMessage
	{
		// Token: 0x06001C93 RID: 7315 RVA: 0x0004F2AD File Offset: 0x0004D4AD
		[NullableContext(1)]
		public static AddForbidControlNotify Create()
		{
			return new AddForbidControlNotify();
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x0004F2B4 File Offset: 0x0004D4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x0004F2B7 File Offset: 0x0004D4B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddForbidControlNotify.Descriptor;
			}
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0004F2BE File Offset: 0x0004D4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddForbidControlNotify()
		{
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0004F2D1 File Offset: 0x0004D4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddForbidControlNotify(AddForbidControlNotify other) : this()
		{
			this.forbidList_ = other.forbidList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0004F2FB File Offset: 0x0004D4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddForbidControlNotify Clone()
		{
			return new AddForbidControlNotify(this);
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x0004F303 File Offset: 0x0004D503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ControlParam> ForbidList
		{
			get
			{
				return this.forbidList_;
			}
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0004F30B File Offset: 0x0004D50B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddForbidControlNotify);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0004F319 File Offset: 0x0004D519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddForbidControlNotify other)
		{
			return other != null && (other == this || (this.forbidList_.Equals(other.forbidList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0004F34C File Offset: 0x0004D54C
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

		// Token: 0x06001C9D RID: 7325 RVA: 0x0004F380 File Offset: 0x0004D580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0004F38D File Offset: 0x0004D58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0004F396 File Offset: 0x0004D596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.forbidList_.WriteTo(ref output, AddForbidControlNotify._repeated_forbidList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0004F3C0 File Offset: 0x0004D5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.forbidList_.CalculateSize(AddForbidControlNotify._repeated_forbidList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0004F3F9 File Offset: 0x0004D5F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddForbidControlNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.forbidList_.Add(other.forbidList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0004F427 File Offset: 0x0004D627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0004F430 File Offset: 0x0004D630
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.forbidList_.AddEntriesFrom(ref input, AddForbidControlNotify._repeated_forbidList_codec);
				}
			}
		}

		// Token: 0x040022E7 RID: 8935
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022E8 RID: 8936
		public const int ForbidListFieldNumber = 13;

		// Token: 0x040022E9 RID: 8937
		private static readonly FieldCodec<ControlParam> _repeated_forbidList_codec = FieldCodec.ForMessage<ControlParam>(106U, ControlParam.Parser);

		// Token: 0x040022EA RID: 8938
		private readonly RepeatedField<ControlParam> forbidList_ = new RepeatedField<ControlParam>();
	}
}
