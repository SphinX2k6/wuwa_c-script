using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200005C RID: 92
	[NetMessage(EMessageId.AchievementFinishResponse)]
	public sealed class AchievementFinishResponse : IMessage<AchievementFinishResponse>, IMessage, IEquatable<AchievementFinishResponse>, IDeepCloneable<AchievementFinishResponse>, IBufferMessage
	{
		// Token: 0x060015C8 RID: 5576 RVA: 0x00039A35 File Offset: 0x00037C35
		[NullableContext(1)]
		public static AchievementFinishResponse Create()
		{
			return new AchievementFinishResponse();
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00039A3C File Offset: 0x00037C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x00039A3F File Offset: 0x00037C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementFinishResponse.Descriptor;
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00039A46 File Offset: 0x00037C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementFinishResponse()
		{
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00039A4E File Offset: 0x00037C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementFinishResponse(AchievementFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00039A73 File Offset: 0x00037C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementFinishResponse Clone()
		{
			return new AchievementFinishResponse(this);
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x00039A7B File Offset: 0x00037C7B
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x00039A83 File Offset: 0x00037C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00039A8C File Offset: 0x00037C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementFinishResponse);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00039A9A File Offset: 0x00037C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00039AC8 File Offset: 0x00037CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00039B0D File Offset: 0x00037D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00039B1A File Offset: 0x00037D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00039B23 File Offset: 0x00037D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00039B58 File Offset: 0x00037D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00039B96 File Offset: 0x00037D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementFinishResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00039BC7 File Offset: 0x00037DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00039BD0 File Offset: 0x00037DD0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040020B8 RID: 8376
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020B9 RID: 8377
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040020BA RID: 8378
		private ErrorCode errorCode_;
	}
}
