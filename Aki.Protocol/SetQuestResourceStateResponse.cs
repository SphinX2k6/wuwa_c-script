using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001219 RID: 4633
	[NetMessage(EMessageId.SetQuestResourceStateResponse)]
	public sealed class SetQuestResourceStateResponse : IMessage<SetQuestResourceStateResponse>, IMessage, IEquatable<SetQuestResourceStateResponse>, IDeepCloneable<SetQuestResourceStateResponse>, IBufferMessage
	{
		// Token: 0x06018BD9 RID: 101337 RVA: 0x0039B121 File Offset: 0x00399321
		[NullableContext(1)]
		public static SetQuestResourceStateResponse Create()
		{
			return new SetQuestResourceStateResponse();
		}

		// Token: 0x17005385 RID: 21381
		// (get) Token: 0x06018BDA RID: 101338 RVA: 0x0039B128 File Offset: 0x00399328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005386 RID: 21382
		// (get) Token: 0x06018BDB RID: 101339 RVA: 0x0039B12B File Offset: 0x0039932B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetQuestResourceStateResponse.Descriptor;
			}
		}

		// Token: 0x06018BDC RID: 101340 RVA: 0x0039B132 File Offset: 0x00399332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestResourceStateResponse()
		{
		}

		// Token: 0x06018BDD RID: 101341 RVA: 0x0039B13A File Offset: 0x0039933A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestResourceStateResponse(SetQuestResourceStateResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018BDE RID: 101342 RVA: 0x0039B15F File Offset: 0x0039935F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestResourceStateResponse Clone()
		{
			return new SetQuestResourceStateResponse(this);
		}

		// Token: 0x17005387 RID: 21383
		// (get) Token: 0x06018BDF RID: 101343 RVA: 0x0039B167 File Offset: 0x00399367
		// (set) Token: 0x06018BE0 RID: 101344 RVA: 0x0039B16F File Offset: 0x0039936F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x06018BE1 RID: 101345 RVA: 0x0039B178 File Offset: 0x00399378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetQuestResourceStateResponse);
		}

		// Token: 0x06018BE2 RID: 101346 RVA: 0x0039B186 File Offset: 0x00399386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetQuestResourceStateResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018BE3 RID: 101347 RVA: 0x0039B1B4 File Offset: 0x003993B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018BE4 RID: 101348 RVA: 0x0039B1F9 File Offset: 0x003993F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018BE5 RID: 101349 RVA: 0x0039B206 File Offset: 0x00399406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018BE6 RID: 101350 RVA: 0x0039B20F File Offset: 0x0039940F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018BE7 RID: 101351 RVA: 0x0039B244 File Offset: 0x00399444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018BE8 RID: 101352 RVA: 0x0039B282 File Offset: 0x00399482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetQuestResourceStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018BE9 RID: 101353 RVA: 0x0039B2B3 File Offset: 0x003994B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018BEA RID: 101354 RVA: 0x0039B2BC File Offset: 0x003994BC
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040092CA RID: 37578
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092CB RID: 37579
		public const int ErrorIdFieldNumber = 15;

		// Token: 0x040092CC RID: 37580
		private ErrorCode errorId_;
	}
}
