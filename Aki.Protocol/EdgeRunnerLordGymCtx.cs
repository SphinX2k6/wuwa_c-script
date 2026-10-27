using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000423 RID: 1059
	public sealed class EdgeRunnerLordGymCtx : IMessage<EdgeRunnerLordGymCtx>, IMessage, IEquatable<EdgeRunnerLordGymCtx>, IDeepCloneable<EdgeRunnerLordGymCtx>, IBufferMessage
	{
		// Token: 0x060065CB RID: 26059 RVA: 0x000F4FA1 File Offset: 0x000F31A1
		[NullableContext(1)]
		public static EdgeRunnerLordGymCtx Create()
		{
			return new EdgeRunnerLordGymCtx();
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x060065CC RID: 26060 RVA: 0x000F4FA8 File Offset: 0x000F31A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x060065CD RID: 26061 RVA: 0x000F4FAB File Offset: 0x000F31AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerLordGymCtx.Descriptor;
			}
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x000F4FB2 File Offset: 0x000F31B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymCtx()
		{
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x000F4FBA File Offset: 0x000F31BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymCtx(EdgeRunnerLordGymCtx other) : this()
		{
			this.lordGymId_ = other.lordGymId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x000F4FDF File Offset: 0x000F31DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerLordGymCtx Clone()
		{
			return new EdgeRunnerLordGymCtx(this);
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x060065D1 RID: 26065 RVA: 0x000F4FE7 File Offset: 0x000F31E7
		// (set) Token: 0x060065D2 RID: 26066 RVA: 0x000F4FEF File Offset: 0x000F31EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LordGymId
		{
			get
			{
				return this.lordGymId_;
			}
			set
			{
				this.lordGymId_ = value;
			}
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x000F4FF8 File Offset: 0x000F31F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerLordGymCtx);
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x000F5006 File Offset: 0x000F3206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerLordGymCtx other)
		{
			return other != null && (other == this || (this.LordGymId == other.LordGymId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x000F5034 File Offset: 0x000F3234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LordGymId != 0)
			{
				num ^= this.LordGymId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x000F5073 File Offset: 0x000F3273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060065D7 RID: 26071 RVA: 0x000F5080 File Offset: 0x000F3280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x000F5089 File Offset: 0x000F3289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LordGymId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LordGymId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x000F50BC File Offset: 0x000F32BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LordGymId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LordGymId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x000F50FA File Offset: 0x000F32FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerLordGymCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LordGymId != 0)
			{
				this.LordGymId = other.LordGymId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x000F512B File Offset: 0x000F332B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x000F5134 File Offset: 0x000F3334
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
					this.LordGymId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040038F6 RID: 14582
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038F7 RID: 14583
		public const int LordGymIdFieldNumber = 1;

		// Token: 0x040038F8 RID: 14584
		private int lordGymId_;
	}
}
