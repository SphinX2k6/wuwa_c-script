using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000903 RID: 2307
	public sealed class LevelPlayRewardActionCtxPb : IMessage<LevelPlayRewardActionCtxPb>, IMessage, IEquatable<LevelPlayRewardActionCtxPb>, IDeepCloneable<LevelPlayRewardActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600CBC4 RID: 52164 RVA: 0x001E0D04 File Offset: 0x001DEF04
		[NullableContext(1)]
		public static LevelPlayRewardActionCtxPb Create()
		{
			return new LevelPlayRewardActionCtxPb();
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x0600CBC5 RID: 52165 RVA: 0x001E0D0B File Offset: 0x001DEF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x0600CBC6 RID: 52166 RVA: 0x001E0D0E File Offset: 0x001DEF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayRewardActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600CBC7 RID: 52167 RVA: 0x001E0D15 File Offset: 0x001DEF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardActionCtxPb()
		{
		}

		// Token: 0x0600CBC8 RID: 52168 RVA: 0x001E0D1D File Offset: 0x001DEF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardActionCtxPb(LevelPlayRewardActionCtxPb other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBC9 RID: 52169 RVA: 0x001E0D42 File Offset: 0x001DEF42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardActionCtxPb Clone()
		{
			return new LevelPlayRewardActionCtxPb(this);
		}

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x0600CBCA RID: 52170 RVA: 0x001E0D4A File Offset: 0x001DEF4A
		// (set) Token: 0x0600CBCB RID: 52171 RVA: 0x001E0D52 File Offset: 0x001DEF52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x0600CBCC RID: 52172 RVA: 0x001E0D5B File Offset: 0x001DEF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayRewardActionCtxPb);
		}

		// Token: 0x0600CBCD RID: 52173 RVA: 0x001E0D69 File Offset: 0x001DEF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayRewardActionCtxPb other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBCE RID: 52174 RVA: 0x001E0D98 File Offset: 0x001DEF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CBCF RID: 52175 RVA: 0x001E0DD7 File Offset: 0x001DEFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CBD0 RID: 52176 RVA: 0x001E0DE4 File Offset: 0x001DEFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBD1 RID: 52177 RVA: 0x001E0DED File Offset: 0x001DEFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CBD2 RID: 52178 RVA: 0x001E0E20 File Offset: 0x001DF020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CBD3 RID: 52179 RVA: 0x001E0E5E File Offset: 0x001DF05E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayRewardActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CBD4 RID: 52180 RVA: 0x001E0E8F File Offset: 0x001DF08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBD5 RID: 52181 RVA: 0x001E0E98 File Offset: 0x001DF098
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
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400567F RID: 22143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005680 RID: 22144
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x04005681 RID: 22145
		private int levelPlayId_;
	}
}
