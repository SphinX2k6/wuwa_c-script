using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D8 RID: 5080
	[NetMessage(EMessageId.TraceRecallQuestNotify)]
	public sealed class TraceRecallQuestNotify : IMessage<TraceRecallQuestNotify>, IMessage, IEquatable<TraceRecallQuestNotify>, IDeepCloneable<TraceRecallQuestNotify>, IBufferMessage
	{
		// Token: 0x0601AEFD RID: 110333 RVA: 0x003E7528 File Offset: 0x003E5728
		[NullableContext(1)]
		public static TraceRecallQuestNotify Create()
		{
			return new TraceRecallQuestNotify();
		}

		// Token: 0x17005AD3 RID: 23251
		// (get) Token: 0x0601AEFE RID: 110334 RVA: 0x003E752F File Offset: 0x003E572F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AD4 RID: 23252
		// (get) Token: 0x0601AEFF RID: 110335 RVA: 0x003E7532 File Offset: 0x003E5732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceRecallQuestNotify.Descriptor;
			}
		}

		// Token: 0x0601AF00 RID: 110336 RVA: 0x003E7539 File Offset: 0x003E5739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestNotify()
		{
		}

		// Token: 0x0601AF01 RID: 110337 RVA: 0x003E7541 File Offset: 0x003E5741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestNotify(TraceRecallQuestNotify other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF02 RID: 110338 RVA: 0x003E7566 File Offset: 0x003E5766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestNotify Clone()
		{
			return new TraceRecallQuestNotify(this);
		}

		// Token: 0x17005AD5 RID: 23253
		// (get) Token: 0x0601AF03 RID: 110339 RVA: 0x003E756E File Offset: 0x003E576E
		// (set) Token: 0x0601AF04 RID: 110340 RVA: 0x003E7576 File Offset: 0x003E5776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x0601AF05 RID: 110341 RVA: 0x003E757F File Offset: 0x003E577F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceRecallQuestNotify);
		}

		// Token: 0x0601AF06 RID: 110342 RVA: 0x003E758D File Offset: 0x003E578D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceRecallQuestNotify other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF07 RID: 110343 RVA: 0x003E75BC File Offset: 0x003E57BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AF08 RID: 110344 RVA: 0x003E75FB File Offset: 0x003E57FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF09 RID: 110345 RVA: 0x003E7608 File Offset: 0x003E5808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF0A RID: 110346 RVA: 0x003E7611 File Offset: 0x003E5811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF0B RID: 110347 RVA: 0x003E7644 File Offset: 0x003E5844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AF0C RID: 110348 RVA: 0x003E7682 File Offset: 0x003E5882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceRecallQuestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AF0D RID: 110349 RVA: 0x003E76B3 File Offset: 0x003E58B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF0E RID: 110350 RVA: 0x003E76BC File Offset: 0x003E58BC
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
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C23 RID: 39971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C24 RID: 39972
		public const int RecallQuestIdFieldNumber = 2;

		// Token: 0x04009C25 RID: 39973
		private int recallQuestId_;
	}
}
