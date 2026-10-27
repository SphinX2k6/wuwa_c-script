using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200128B RID: 4747
	[NetMessage(EMessageId.StartMatchNotify)]
	public sealed class StartMatchNotify : IMessage<StartMatchNotify>, IMessage, IEquatable<StartMatchNotify>, IDeepCloneable<StartMatchNotify>, IBufferMessage
	{
		// Token: 0x06019472 RID: 103538 RVA: 0x003AD1E3 File Offset: 0x003AB3E3
		[NullableContext(1)]
		public static StartMatchNotify Create()
		{
			return new StartMatchNotify();
		}

		// Token: 0x17005545 RID: 21829
		// (get) Token: 0x06019473 RID: 103539 RVA: 0x003AD1EA File Offset: 0x003AB3EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005546 RID: 21830
		// (get) Token: 0x06019474 RID: 103540 RVA: 0x003AD1ED File Offset: 0x003AB3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartMatchNotify.Descriptor;
			}
		}

		// Token: 0x06019475 RID: 103541 RVA: 0x003AD1F4 File Offset: 0x003AB3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchNotify()
		{
		}

		// Token: 0x06019476 RID: 103542 RVA: 0x003AD1FC File Offset: 0x003AB3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchNotify(StartMatchNotify other) : this()
		{
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019477 RID: 103543 RVA: 0x003AD221 File Offset: 0x003AB421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchNotify Clone()
		{
			return new StartMatchNotify(this);
		}

		// Token: 0x17005547 RID: 21831
		// (get) Token: 0x06019478 RID: 103544 RVA: 0x003AD229 File Offset: 0x003AB429
		// (set) Token: 0x06019479 RID: 103545 RVA: 0x003AD231 File Offset: 0x003AB431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x0601947A RID: 103546 RVA: 0x003AD23A File Offset: 0x003AB43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartMatchNotify);
		}

		// Token: 0x0601947B RID: 103547 RVA: 0x003AD248 File Offset: 0x003AB448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartMatchNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601947C RID: 103548 RVA: 0x003AD278 File Offset: 0x003AB478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601947D RID: 103549 RVA: 0x003AD2B7 File Offset: 0x003AB4B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601947E RID: 103550 RVA: 0x003AD2C4 File Offset: 0x003AB4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601947F RID: 103551 RVA: 0x003AD2CD File Offset: 0x003AB4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019480 RID: 103552 RVA: 0x003AD300 File Offset: 0x003AB500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019481 RID: 103553 RVA: 0x003AD33E File Offset: 0x003AB53E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartMatchNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019482 RID: 103554 RVA: 0x003AD36F File Offset: 0x003AB56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019483 RID: 103555 RVA: 0x003AD378 File Offset: 0x003AB578
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040094A6 RID: 38054
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094A7 RID: 38055
		public const int InstIdFieldNumber = 10;

		// Token: 0x040094A8 RID: 38056
		private int instId_;
	}
}
