using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001028 RID: 4136
	[NetMessage(EMessageId.RogueWeeklyGotoNextRoomRequest)]
	public sealed class RogueWeeklyGotoNextRoomRequest : IMessage<RogueWeeklyGotoNextRoomRequest>, IMessage, IEquatable<RogueWeeklyGotoNextRoomRequest>, IDeepCloneable<RogueWeeklyGotoNextRoomRequest>, IBufferMessage
	{
		// Token: 0x0601622A RID: 90666 RVA: 0x00338024 File Offset: 0x00336224
		[NullableContext(1)]
		public static RogueWeeklyGotoNextRoomRequest Create()
		{
			return new RogueWeeklyGotoNextRoomRequest();
		}

		// Token: 0x17004A07 RID: 18951
		// (get) Token: 0x0601622B RID: 90667 RVA: 0x0033802B File Offset: 0x0033622B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A08 RID: 18952
		// (get) Token: 0x0601622C RID: 90668 RVA: 0x0033802E File Offset: 0x0033622E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyGotoNextRoomRequest.Descriptor;
			}
		}

		// Token: 0x0601622D RID: 90669 RVA: 0x00338035 File Offset: 0x00336235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGotoNextRoomRequest()
		{
		}

		// Token: 0x0601622E RID: 90670 RVA: 0x0033803D File Offset: 0x0033623D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGotoNextRoomRequest(RogueWeeklyGotoNextRoomRequest other) : this()
		{
			this.confirm_ = other.confirm_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601622F RID: 90671 RVA: 0x00338062 File Offset: 0x00336262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGotoNextRoomRequest Clone()
		{
			return new RogueWeeklyGotoNextRoomRequest(this);
		}

		// Token: 0x17004A09 RID: 18953
		// (get) Token: 0x06016230 RID: 90672 RVA: 0x0033806A File Offset: 0x0033626A
		// (set) Token: 0x06016231 RID: 90673 RVA: 0x00338072 File Offset: 0x00336272
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

		// Token: 0x06016232 RID: 90674 RVA: 0x0033807B File Offset: 0x0033627B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyGotoNextRoomRequest);
		}

		// Token: 0x06016233 RID: 90675 RVA: 0x00338089 File Offset: 0x00336289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyGotoNextRoomRequest other)
		{
			return other != null && (other == this || (this.Confirm == other.Confirm && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016234 RID: 90676 RVA: 0x003380B8 File Offset: 0x003362B8
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

		// Token: 0x06016235 RID: 90677 RVA: 0x003380F7 File Offset: 0x003362F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016236 RID: 90678 RVA: 0x00338104 File Offset: 0x00336304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016237 RID: 90679 RVA: 0x0033810D File Offset: 0x0033630D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Confirm)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.Confirm);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016238 RID: 90680 RVA: 0x00338140 File Offset: 0x00336340
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

		// Token: 0x06016239 RID: 90681 RVA: 0x00338172 File Offset: 0x00336372
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

		// Token: 0x0601623A RID: 90682 RVA: 0x003381A3 File Offset: 0x003363A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601623B RID: 90683 RVA: 0x003381AC File Offset: 0x003363AC
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Confirm = input.ReadBool();
				}
			}
		}

		// Token: 0x04008500 RID: 34048
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008501 RID: 34049
		public const int ConfirmFieldNumber = 14;

		// Token: 0x04008502 RID: 34050
		private bool confirm_;
	}
}
