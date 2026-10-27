using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F3A RID: 3898
	public sealed class RhythmCtx : IMessage<RhythmCtx>, IMessage, IEquatable<RhythmCtx>, IDeepCloneable<RhythmCtx>, IBufferMessage
	{
		// Token: 0x06014DBA RID: 85434 RVA: 0x00306AD9 File Offset: 0x00304CD9
		[NullableContext(1)]
		public static RhythmCtx Create()
		{
			return new RhythmCtx();
		}

		// Token: 0x1700455A RID: 17754
		// (get) Token: 0x06014DBB RID: 85435 RVA: 0x00306AE0 File Offset: 0x00304CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700455B RID: 17755
		// (get) Token: 0x06014DBC RID: 85436 RVA: 0x00306AE3 File Offset: 0x00304CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmCtx.Descriptor;
			}
		}

		// Token: 0x06014DBD RID: 85437 RVA: 0x00306AEA File Offset: 0x00304CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmCtx()
		{
		}

		// Token: 0x06014DBE RID: 85438 RVA: 0x00306AF2 File Offset: 0x00304CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmCtx(RhythmCtx other) : this()
		{
			this.subLevelId_ = other.subLevelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014DBF RID: 85439 RVA: 0x00306B17 File Offset: 0x00304D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmCtx Clone()
		{
			return new RhythmCtx(this);
		}

		// Token: 0x1700455C RID: 17756
		// (get) Token: 0x06014DC0 RID: 85440 RVA: 0x00306B1F File Offset: 0x00304D1F
		// (set) Token: 0x06014DC1 RID: 85441 RVA: 0x00306B27 File Offset: 0x00304D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelId
		{
			get
			{
				return this.subLevelId_;
			}
			set
			{
				this.subLevelId_ = value;
			}
		}

		// Token: 0x06014DC2 RID: 85442 RVA: 0x00306B30 File Offset: 0x00304D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmCtx);
		}

		// Token: 0x06014DC3 RID: 85443 RVA: 0x00306B3E File Offset: 0x00304D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmCtx other)
		{
			return other != null && (other == this || (this.SubLevelId == other.SubLevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014DC4 RID: 85444 RVA: 0x00306B6C File Offset: 0x00304D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelId != 0)
			{
				num ^= this.SubLevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014DC5 RID: 85445 RVA: 0x00306BAB File Offset: 0x00304DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014DC6 RID: 85446 RVA: 0x00306BB8 File Offset: 0x00304DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014DC7 RID: 85447 RVA: 0x00306BC1 File Offset: 0x00304DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014DC8 RID: 85448 RVA: 0x00306BF4 File Offset: 0x00304DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014DC9 RID: 85449 RVA: 0x00306C32 File Offset: 0x00304E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelId != 0)
			{
				this.SubLevelId = other.SubLevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014DCA RID: 85450 RVA: 0x00306C63 File Offset: 0x00304E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014DCB RID: 85451 RVA: 0x00306C6C File Offset: 0x00304E6C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SubLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007DD9 RID: 32217
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DDA RID: 32218
		public const int SubLevelIdFieldNumber = 2;

		// Token: 0x04007DDB RID: 32219
		private int subLevelId_;
	}
}
