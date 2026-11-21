using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000325 RID: 805
	[NetMessage(EMessageId.DailyAdventurePtRewardRequest)]
	public sealed class DailyAdventurePtRewardRequest : IMessage<DailyAdventurePtRewardRequest>, IMessage, IEquatable<DailyAdventurePtRewardRequest>, IDeepCloneable<DailyAdventurePtRewardRequest>, IBufferMessage
	{
		// Token: 0x0600513B RID: 20795 RVA: 0x000C64E0 File Offset: 0x000C46E0
		[NullableContext(1)]
		public static DailyAdventurePtRewardRequest Create()
		{
			return new DailyAdventurePtRewardRequest();
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x0600513C RID: 20796 RVA: 0x000C64E7 File Offset: 0x000C46E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x0600513D RID: 20797 RVA: 0x000C64EA File Offset: 0x000C46EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventurePtRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x000C64F1 File Offset: 0x000C46F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventurePtRewardRequest()
		{
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x000C64F9 File Offset: 0x000C46F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventurePtRewardRequest(DailyAdventurePtRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x000C651E File Offset: 0x000C471E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventurePtRewardRequest Clone()
		{
			return new DailyAdventurePtRewardRequest(this);
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06005141 RID: 20801 RVA: 0x000C6526 File Offset: 0x000C4726
		// (set) Token: 0x06005142 RID: 20802 RVA: 0x000C652E File Offset: 0x000C472E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x000C6537 File Offset: 0x000C4737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventurePtRewardRequest);
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x000C6545 File Offset: 0x000C4745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventurePtRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x000C6574 File Offset: 0x000C4774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x000C65B3 File Offset: 0x000C47B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005147 RID: 20807 RVA: 0x000C65C0 File Offset: 0x000C47C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x000C65C9 File Offset: 0x000C47C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x000C65FC File Offset: 0x000C47FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x000C663A File Offset: 0x000C483A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyAdventurePtRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x000C666B File Offset: 0x000C486B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x000C6674 File Offset: 0x000C4874
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040032FC RID: 13052
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032FD RID: 13053
		public const int IdFieldNumber = 8;

		// Token: 0x040032FE RID: 13054
		private int id_;
	}
}
