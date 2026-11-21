using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001022 RID: 4130
	public sealed class RogueWeeklyBuff : IMessage<RogueWeeklyBuff>, IMessage, IEquatable<RogueWeeklyBuff>, IDeepCloneable<RogueWeeklyBuff>, IBufferMessage
	{
		// Token: 0x0601619C RID: 90524 RVA: 0x0033695B File Offset: 0x00334B5B
		[NullableContext(1)]
		public static RogueWeeklyBuff Create()
		{
			return new RogueWeeklyBuff();
		}

		// Token: 0x170049E4 RID: 18916
		// (get) Token: 0x0601619D RID: 90525 RVA: 0x00336962 File Offset: 0x00334B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049E5 RID: 18917
		// (get) Token: 0x0601619E RID: 90526 RVA: 0x00336965 File Offset: 0x00334B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyBuff.Descriptor;
			}
		}

		// Token: 0x0601619F RID: 90527 RVA: 0x0033696C File Offset: 0x00334B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBuff()
		{
		}

		// Token: 0x060161A0 RID: 90528 RVA: 0x00336974 File Offset: 0x00334B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBuff(RogueWeeklyBuff other) : this()
		{
			this.isNew_ = other.isNew_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060161A1 RID: 90529 RVA: 0x00336999 File Offset: 0x00334B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBuff Clone()
		{
			return new RogueWeeklyBuff(this);
		}

		// Token: 0x170049E6 RID: 18918
		// (get) Token: 0x060161A2 RID: 90530 RVA: 0x003369A1 File Offset: 0x00334BA1
		// (set) Token: 0x060161A3 RID: 90531 RVA: 0x003369A9 File Offset: 0x00334BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x060161A4 RID: 90532 RVA: 0x003369B2 File Offset: 0x00334BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyBuff);
		}

		// Token: 0x060161A5 RID: 90533 RVA: 0x003369C0 File Offset: 0x00334BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyBuff other)
		{
			return other != null && (other == this || (this.IsNew == other.IsNew && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060161A6 RID: 90534 RVA: 0x003369F0 File Offset: 0x00334BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060161A7 RID: 90535 RVA: 0x00336A2F File Offset: 0x00334C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060161A8 RID: 90536 RVA: 0x00336A3C File Offset: 0x00334C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060161A9 RID: 90537 RVA: 0x00336A45 File Offset: 0x00334C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNew)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsNew);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060161AA RID: 90538 RVA: 0x00336A78 File Offset: 0x00334C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsNew)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060161AB RID: 90539 RVA: 0x00336AAA File Offset: 0x00334CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyBuff other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060161AC RID: 90540 RVA: 0x00336ADB File Offset: 0x00334CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060161AD RID: 90541 RVA: 0x00336AE4 File Offset: 0x00334CE4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsNew = input.ReadBool();
				}
			}
		}

		// Token: 0x040084CC RID: 33996
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084CD RID: 33997
		public const int IsNewFieldNumber = 1;

		// Token: 0x040084CE RID: 33998
		private bool isNew_;
	}
}
