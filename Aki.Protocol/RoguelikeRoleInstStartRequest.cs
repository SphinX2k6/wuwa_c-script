using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA1 RID: 4001
	[NetMessage(EMessageId.RoguelikeRoleInstStartRequest)]
	public sealed class RoguelikeRoleInstStartRequest : IMessage<RoguelikeRoleInstStartRequest>, IMessage, IEquatable<RoguelikeRoleInstStartRequest>, IDeepCloneable<RoguelikeRoleInstStartRequest>, IBufferMessage
	{
		// Token: 0x060156CE RID: 87758 RVA: 0x0031CF23 File Offset: 0x0031B123
		[NullableContext(1)]
		public static RoguelikeRoleInstStartRequest Create()
		{
			return new RoguelikeRoleInstStartRequest();
		}

		// Token: 0x17004776 RID: 18294
		// (get) Token: 0x060156CF RID: 87759 RVA: 0x0031CF2A File Offset: 0x0031B12A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004777 RID: 18295
		// (get) Token: 0x060156D0 RID: 87760 RVA: 0x0031CF2D File Offset: 0x0031B12D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRoleInstStartRequest.Descriptor;
			}
		}

		// Token: 0x060156D1 RID: 87761 RVA: 0x0031CF34 File Offset: 0x0031B134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleInstStartRequest()
		{
		}

		// Token: 0x060156D2 RID: 87762 RVA: 0x0031CF3C File Offset: 0x0031B13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleInstStartRequest(RoguelikeRoleInstStartRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060156D3 RID: 87763 RVA: 0x0031CF6D File Offset: 0x0031B16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleInstStartRequest Clone()
		{
			return new RoguelikeRoleInstStartRequest(this);
		}

		// Token: 0x17004778 RID: 18296
		// (get) Token: 0x060156D4 RID: 87764 RVA: 0x0031CF75 File Offset: 0x0031B175
		// (set) Token: 0x060156D5 RID: 87765 RVA: 0x0031CF7D File Offset: 0x0031B17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17004779 RID: 18297
		// (get) Token: 0x060156D6 RID: 87766 RVA: 0x0031CF86 File Offset: 0x0031B186
		// (set) Token: 0x060156D7 RID: 87767 RVA: 0x0031CF8E File Offset: 0x0031B18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060156D8 RID: 87768 RVA: 0x0031CF97 File Offset: 0x0031B197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRoleInstStartRequest);
		}

		// Token: 0x060156D9 RID: 87769 RVA: 0x0031CFA5 File Offset: 0x0031B1A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRoleInstStartRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060156DA RID: 87770 RVA: 0x0031CFE4 File Offset: 0x0031B1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060156DB RID: 87771 RVA: 0x0031D03C File Offset: 0x0031B23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060156DC RID: 87772 RVA: 0x0031D049 File Offset: 0x0031B249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060156DD RID: 87773 RVA: 0x0031D054 File Offset: 0x0031B254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060156DE RID: 87774 RVA: 0x0031D0B0 File Offset: 0x0031B2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060156DF RID: 87775 RVA: 0x0031D108 File Offset: 0x0031B308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeRoleInstStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060156E0 RID: 87776 RVA: 0x0031D158 File Offset: 0x0031B358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060156E1 RID: 87777 RVA: 0x0031D164 File Offset: 0x0031B364
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008156 RID: 33110
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008157 RID: 33111
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04008158 RID: 33112
		private int activityId_;

		// Token: 0x04008159 RID: 33113
		public const int IndexFieldNumber = 7;

		// Token: 0x0400815A RID: 33114
		private int index_;
	}
}
