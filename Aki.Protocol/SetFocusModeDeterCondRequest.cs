using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200120D RID: 4621
	[NetMessage(EMessageId.SetFocusModeDeterCondRequest)]
	public sealed class SetFocusModeDeterCondRequest : IMessage<SetFocusModeDeterCondRequest>, IMessage, IEquatable<SetFocusModeDeterCondRequest>, IDeepCloneable<SetFocusModeDeterCondRequest>, IBufferMessage
	{
		// Token: 0x06018AFD RID: 101117 RVA: 0x00399931 File Offset: 0x00397B31
		[NullableContext(1)]
		public static SetFocusModeDeterCondRequest Create()
		{
			return new SetFocusModeDeterCondRequest();
		}

		// Token: 0x1700535F RID: 21343
		// (get) Token: 0x06018AFE RID: 101118 RVA: 0x00399938 File Offset: 0x00397B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005360 RID: 21344
		// (get) Token: 0x06018AFF RID: 101119 RVA: 0x0039993B File Offset: 0x00397B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFocusModeDeterCondRequest.Descriptor;
			}
		}

		// Token: 0x06018B00 RID: 101120 RVA: 0x00399942 File Offset: 0x00397B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFocusModeDeterCondRequest()
		{
		}

		// Token: 0x06018B01 RID: 101121 RVA: 0x0039994A File Offset: 0x00397B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFocusModeDeterCondRequest(SetFocusModeDeterCondRequest other) : this()
		{
			this.deterCond_ = other.deterCond_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B02 RID: 101122 RVA: 0x0039996F File Offset: 0x00397B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFocusModeDeterCondRequest Clone()
		{
			return new SetFocusModeDeterCondRequest(this);
		}

		// Token: 0x17005361 RID: 21345
		// (get) Token: 0x06018B03 RID: 101123 RVA: 0x00399977 File Offset: 0x00397B77
		// (set) Token: 0x06018B04 RID: 101124 RVA: 0x0039997F File Offset: 0x00397B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DeterCond
		{
			get
			{
				return this.deterCond_;
			}
			set
			{
				this.deterCond_ = value;
			}
		}

		// Token: 0x06018B05 RID: 101125 RVA: 0x00399988 File Offset: 0x00397B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFocusModeDeterCondRequest);
		}

		// Token: 0x06018B06 RID: 101126 RVA: 0x00399996 File Offset: 0x00397B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFocusModeDeterCondRequest other)
		{
			return other != null && (other == this || (this.DeterCond == other.DeterCond && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B07 RID: 101127 RVA: 0x003999C4 File Offset: 0x00397BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DeterCond)
			{
				num ^= this.DeterCond.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018B08 RID: 101128 RVA: 0x00399A03 File Offset: 0x00397C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B09 RID: 101129 RVA: 0x00399A10 File Offset: 0x00397C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B0A RID: 101130 RVA: 0x00399A19 File Offset: 0x00397C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DeterCond)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.DeterCond);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B0B RID: 101131 RVA: 0x00399A4C File Offset: 0x00397C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DeterCond)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018B0C RID: 101132 RVA: 0x00399A7E File Offset: 0x00397C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFocusModeDeterCondRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DeterCond)
			{
				this.DeterCond = other.DeterCond;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018B0D RID: 101133 RVA: 0x00399AAF File Offset: 0x00397CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B0E RID: 101134 RVA: 0x00399AB8 File Offset: 0x00397CB8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DeterCond = input.ReadBool();
				}
			}
		}

		// Token: 0x040092A2 RID: 37538
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092A3 RID: 37539
		public const int DeterCondFieldNumber = 4;

		// Token: 0x040092A4 RID: 37540
		private bool deterCond_;
	}
}
