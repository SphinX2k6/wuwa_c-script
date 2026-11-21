using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200114B RID: 4427
	[NetMessage(EMessageId.RoverRogueLootInfoRequest)]
	public sealed class RoverRogueLootInfoRequest : IMessage<RoverRogueLootInfoRequest>, IMessage, IEquatable<RoverRogueLootInfoRequest>, IDeepCloneable<RoverRogueLootInfoRequest>, IBufferMessage
	{
		// Token: 0x06017A7B RID: 96891 RVA: 0x00371716 File Offset: 0x0036F916
		[NullableContext(1)]
		public static RoverRogueLootInfoRequest Create()
		{
			return new RoverRogueLootInfoRequest();
		}

		// Token: 0x17004F94 RID: 20372
		// (get) Token: 0x06017A7C RID: 96892 RVA: 0x0037171D File Offset: 0x0036F91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F95 RID: 20373
		// (get) Token: 0x06017A7D RID: 96893 RVA: 0x00371720 File Offset: 0x0036F920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootInfoRequest.Descriptor;
			}
		}

		// Token: 0x06017A7E RID: 96894 RVA: 0x00371727 File Offset: 0x0036F927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfoRequest()
		{
		}

		// Token: 0x06017A7F RID: 96895 RVA: 0x0037172F File Offset: 0x0036F92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfoRequest(RoverRogueLootInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A80 RID: 96896 RVA: 0x00371754 File Offset: 0x0036F954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfoRequest Clone()
		{
			return new RoverRogueLootInfoRequest(this);
		}

		// Token: 0x17004F96 RID: 20374
		// (get) Token: 0x06017A81 RID: 96897 RVA: 0x0037175C File Offset: 0x0036F95C
		// (set) Token: 0x06017A82 RID: 96898 RVA: 0x00371764 File Offset: 0x0036F964
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

		// Token: 0x06017A83 RID: 96899 RVA: 0x0037176D File Offset: 0x0036F96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootInfoRequest);
		}

		// Token: 0x06017A84 RID: 96900 RVA: 0x0037177B File Offset: 0x0036F97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A85 RID: 96901 RVA: 0x003717AC File Offset: 0x0036F9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017A86 RID: 96902 RVA: 0x003717EB File Offset: 0x0036F9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A87 RID: 96903 RVA: 0x003717F8 File Offset: 0x0036F9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A88 RID: 96904 RVA: 0x00371801 File Offset: 0x0036FA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017A89 RID: 96905 RVA: 0x00371834 File Offset: 0x0036FA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017A8A RID: 96906 RVA: 0x00371872 File Offset: 0x0036FA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueLootInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A8B RID: 96907 RVA: 0x003718A3 File Offset: 0x0036FAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A8C RID: 96908 RVA: 0x003718AC File Offset: 0x0036FAAC
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
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008D31 RID: 36145
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D32 RID: 36146
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04008D33 RID: 36147
		private int activityId_;
	}
}
