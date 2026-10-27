using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D3 RID: 4563
	[NetMessage(EMessageId.SetFocusModeDeterCondRequest)]
	public sealed class SetFocusModeDeterCondRequest : IMessage<SetFocusModeDeterCondRequest>, IMessage, IEquatable<SetFocusModeDeterCondRequest>, IDeepCloneable<SetFocusModeDeterCondRequest>, IBufferMessage
	{
		// Token: 0x0601855C RID: 99676 RVA: 0x0038A601 File Offset: 0x00388801
		[NullableContext(1)]
		public static SetFocusModeDeterCondRequest Create()
		{
			return new SetFocusModeDeterCondRequest();
		}

		// Token: 0x170051F3 RID: 20979
		// (get) Token: 0x0601855D RID: 99677 RVA: 0x0038A608 File Offset: 0x00388808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051F4 RID: 20980
		// (get) Token: 0x0601855E RID: 99678 RVA: 0x0038A60B File Offset: 0x0038880B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFocusModeDeterCondRequest.Descriptor;
			}
		}

		// Token: 0x0601855F RID: 99679 RVA: 0x0038A612 File Offset: 0x00388812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFocusModeDeterCondRequest()
		{
		}

		// Token: 0x06018560 RID: 99680 RVA: 0x0038A61A File Offset: 0x0038881A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFocusModeDeterCondRequest(SetFocusModeDeterCondRequest other) : this()
		{
			this.deterCond_ = other.deterCond_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018561 RID: 99681 RVA: 0x0038A63F File Offset: 0x0038883F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFocusModeDeterCondRequest Clone()
		{
			return new SetFocusModeDeterCondRequest(this);
		}

		// Token: 0x170051F5 RID: 20981
		// (get) Token: 0x06018562 RID: 99682 RVA: 0x0038A647 File Offset: 0x00388847
		// (set) Token: 0x06018563 RID: 99683 RVA: 0x0038A64F File Offset: 0x0038884F
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

		// Token: 0x06018564 RID: 99684 RVA: 0x0038A658 File Offset: 0x00388858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFocusModeDeterCondRequest);
		}

		// Token: 0x06018565 RID: 99685 RVA: 0x0038A666 File Offset: 0x00388866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFocusModeDeterCondRequest other)
		{
			return other != null && (other == this || (this.DeterCond == other.DeterCond && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018566 RID: 99686 RVA: 0x0038A694 File Offset: 0x00388894
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

		// Token: 0x06018567 RID: 99687 RVA: 0x0038A6D3 File Offset: 0x003888D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018568 RID: 99688 RVA: 0x0038A6E0 File Offset: 0x003888E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018569 RID: 99689 RVA: 0x0038A6E9 File Offset: 0x003888E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DeterCond)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.DeterCond);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601856A RID: 99690 RVA: 0x0038A71C File Offset: 0x0038891C
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

		// Token: 0x0601856B RID: 99691 RVA: 0x0038A74E File Offset: 0x0038894E
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

		// Token: 0x0601856C RID: 99692 RVA: 0x0038A77F File Offset: 0x0038897F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601856D RID: 99693 RVA: 0x0038A788 File Offset: 0x00388988
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DeterCond = input.ReadBool();
				}
			}
		}

		// Token: 0x0400900F RID: 36879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009010 RID: 36880
		public const int DeterCondFieldNumber = 5;

		// Token: 0x04009011 RID: 36881
		private bool deterCond_;
	}
}
