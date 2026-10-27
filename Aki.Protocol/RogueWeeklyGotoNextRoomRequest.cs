using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001038 RID: 4152
	[NetMessage(EMessageId.RogueWeeklyGotoNextRoomRequest)]
	public sealed class RogueWeeklyGotoNextRoomRequest : IMessage<RogueWeeklyGotoNextRoomRequest>, IMessage, IEquatable<RogueWeeklyGotoNextRoomRequest>, IDeepCloneable<RogueWeeklyGotoNextRoomRequest>, IBufferMessage
	{
		// Token: 0x0601630F RID: 90895 RVA: 0x003396E8 File Offset: 0x003378E8
		[NullableContext(1)]
		public static RogueWeeklyGotoNextRoomRequest Create()
		{
			return new RogueWeeklyGotoNextRoomRequest();
		}

		// Token: 0x17004A31 RID: 18993
		// (get) Token: 0x06016310 RID: 90896 RVA: 0x003396EF File Offset: 0x003378EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A32 RID: 18994
		// (get) Token: 0x06016311 RID: 90897 RVA: 0x003396F2 File Offset: 0x003378F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyGotoNextRoomRequest.Descriptor;
			}
		}

		// Token: 0x06016312 RID: 90898 RVA: 0x003396F9 File Offset: 0x003378F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGotoNextRoomRequest()
		{
		}

		// Token: 0x06016313 RID: 90899 RVA: 0x00339701 File Offset: 0x00337901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGotoNextRoomRequest(RogueWeeklyGotoNextRoomRequest other) : this()
		{
			this.confirm_ = other.confirm_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016314 RID: 90900 RVA: 0x00339726 File Offset: 0x00337926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGotoNextRoomRequest Clone()
		{
			return new RogueWeeklyGotoNextRoomRequest(this);
		}

		// Token: 0x17004A33 RID: 18995
		// (get) Token: 0x06016315 RID: 90901 RVA: 0x0033972E File Offset: 0x0033792E
		// (set) Token: 0x06016316 RID: 90902 RVA: 0x00339736 File Offset: 0x00337936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Confirm
		{
			get
			{
				return this.confirm_;
			}
			set
			{
				this.confirm_ = value;
			}
		}

		// Token: 0x06016317 RID: 90903 RVA: 0x0033973F File Offset: 0x0033793F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyGotoNextRoomRequest);
		}

		// Token: 0x06016318 RID: 90904 RVA: 0x0033974D File Offset: 0x0033794D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyGotoNextRoomRequest other)
		{
			return other != null && (other == this || (this.Confirm == other.Confirm && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016319 RID: 90905 RVA: 0x0033977C File Offset: 0x0033797C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Confirm)
			{
				num ^= this.Confirm.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601631A RID: 90906 RVA: 0x003397BB File Offset: 0x003379BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601631B RID: 90907 RVA: 0x003397C8 File Offset: 0x003379C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601631C RID: 90908 RVA: 0x003397D1 File Offset: 0x003379D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Confirm)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Confirm);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601631D RID: 90909 RVA: 0x00339804 File Offset: 0x00337A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Confirm)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601631E RID: 90910 RVA: 0x00339836 File Offset: 0x00337A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyGotoNextRoomRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Confirm)
			{
				this.Confirm = other.Confirm;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601631F RID: 90911 RVA: 0x00339867 File Offset: 0x00337A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016320 RID: 90912 RVA: 0x00339870 File Offset: 0x00337A70
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
					this.Confirm = input.ReadBool();
				}
			}
		}

		// Token: 0x040084D6 RID: 34006
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084D7 RID: 34007
		public const int ConfirmFieldNumber = 1;

		// Token: 0x040084D8 RID: 34008
		private bool confirm_;
	}
}
