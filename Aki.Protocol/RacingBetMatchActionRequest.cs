using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E2C RID: 3628
	[NetMessage(EMessageId.RacingBetMatchActionRequest)]
	public sealed class RacingBetMatchActionRequest : IMessage<RacingBetMatchActionRequest>, IMessage, IEquatable<RacingBetMatchActionRequest>, IDeepCloneable<RacingBetMatchActionRequest>, IBufferMessage
	{
		// Token: 0x06013814 RID: 79892 RVA: 0x002D6278 File Offset: 0x002D4478
		[NullableContext(1)]
		public static RacingBetMatchActionRequest Create()
		{
			return new RacingBetMatchActionRequest();
		}

		// Token: 0x170040B1 RID: 16561
		// (get) Token: 0x06013815 RID: 79893 RVA: 0x002D627F File Offset: 0x002D447F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040B2 RID: 16562
		// (get) Token: 0x06013816 RID: 79894 RVA: 0x002D6282 File Offset: 0x002D4482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchActionRequest.Descriptor;
			}
		}

		// Token: 0x06013817 RID: 79895 RVA: 0x002D6289 File Offset: 0x002D4489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchActionRequest()
		{
		}

		// Token: 0x06013818 RID: 79896 RVA: 0x002D6291 File Offset: 0x002D4491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchActionRequest(RacingBetMatchActionRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013819 RID: 79897 RVA: 0x002D62C2 File Offset: 0x002D44C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchActionRequest Clone()
		{
			return new RacingBetMatchActionRequest(this);
		}

		// Token: 0x170040B3 RID: 16563
		// (get) Token: 0x0601381A RID: 79898 RVA: 0x002D62CA File Offset: 0x002D44CA
		// (set) Token: 0x0601381B RID: 79899 RVA: 0x002D62D2 File Offset: 0x002D44D2
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

		// Token: 0x170040B4 RID: 16564
		// (get) Token: 0x0601381C RID: 79900 RVA: 0x002D62DB File Offset: 0x002D44DB
		// (set) Token: 0x0601381D RID: 79901 RVA: 0x002D62E3 File Offset: 0x002D44E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x0601381E RID: 79902 RVA: 0x002D62EC File Offset: 0x002D44EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchActionRequest);
		}

		// Token: 0x0601381F RID: 79903 RVA: 0x002D62FA File Offset: 0x002D44FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchActionRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013820 RID: 79904 RVA: 0x002D6338 File Offset: 0x002D4538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013821 RID: 79905 RVA: 0x002D6390 File Offset: 0x002D4590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013822 RID: 79906 RVA: 0x002D639D File Offset: 0x002D459D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013823 RID: 79907 RVA: 0x002D63A8 File Offset: 0x002D45A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013824 RID: 79908 RVA: 0x002D6404 File Offset: 0x002D4604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013825 RID: 79909 RVA: 0x002D645C File Offset: 0x002D465C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013826 RID: 79910 RVA: 0x002D64AC File Offset: 0x002D46AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013827 RID: 79911 RVA: 0x002D64B8 File Offset: 0x002D46B8
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LegMatchId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040077DF RID: 30687
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077E0 RID: 30688
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x040077E1 RID: 30689
		private int activityId_;

		// Token: 0x040077E2 RID: 30690
		public const int LegMatchIdFieldNumber = 14;

		// Token: 0x040077E3 RID: 30691
		private int legMatchId_;
	}
}
