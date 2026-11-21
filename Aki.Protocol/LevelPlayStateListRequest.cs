using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F8 RID: 2296
	[NetMessage(EMessageId.LevelPlayStateListRequest)]
	public sealed class LevelPlayStateListRequest : IMessage<LevelPlayStateListRequest>, IMessage, IEquatable<LevelPlayStateListRequest>, IDeepCloneable<LevelPlayStateListRequest>, IBufferMessage
	{
		// Token: 0x0600CB1A RID: 51994 RVA: 0x001DF6ED File Offset: 0x001DD8ED
		[NullableContext(1)]
		public static LevelPlayStateListRequest Create()
		{
			return new LevelPlayStateListRequest();
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x0600CB1B RID: 51995 RVA: 0x001DF6F4 File Offset: 0x001DD8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x0600CB1C RID: 51996 RVA: 0x001DF6F7 File Offset: 0x001DD8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayStateListRequest.Descriptor;
			}
		}

		// Token: 0x0600CB1D RID: 51997 RVA: 0x001DF6FE File Offset: 0x001DD8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateListRequest()
		{
		}

		// Token: 0x0600CB1E RID: 51998 RVA: 0x001DF711 File Offset: 0x001DD911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateListRequest(LevelPlayStateListRequest other) : this()
		{
			this.instLevelPlayStateReqs_ = other.instLevelPlayStateReqs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB1F RID: 51999 RVA: 0x001DF73B File Offset: 0x001DD93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateListRequest Clone()
		{
			return new LevelPlayStateListRequest(this);
		}

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x0600CB20 RID: 52000 RVA: 0x001DF743 File Offset: 0x001DD943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InstLevelPlayStateReq> InstLevelPlayStateReqs
		{
			get
			{
				return this.instLevelPlayStateReqs_;
			}
		}

		// Token: 0x0600CB21 RID: 52001 RVA: 0x001DF74B File Offset: 0x001DD94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayStateListRequest);
		}

		// Token: 0x0600CB22 RID: 52002 RVA: 0x001DF759 File Offset: 0x001DD959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayStateListRequest other)
		{
			return other != null && (other == this || (this.instLevelPlayStateReqs_.Equals(other.instLevelPlayStateReqs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB23 RID: 52003 RVA: 0x001DF78C File Offset: 0x001DD98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.instLevelPlayStateReqs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB24 RID: 52004 RVA: 0x001DF7C0 File Offset: 0x001DD9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB25 RID: 52005 RVA: 0x001DF7CD File Offset: 0x001DD9CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB26 RID: 52006 RVA: 0x001DF7D6 File Offset: 0x001DD9D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instLevelPlayStateReqs_.WriteTo(ref output, LevelPlayStateListRequest._repeated_instLevelPlayStateReqs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB27 RID: 52007 RVA: 0x001DF800 File Offset: 0x001DDA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.instLevelPlayStateReqs_.CalculateSize(LevelPlayStateListRequest._repeated_instLevelPlayStateReqs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB28 RID: 52008 RVA: 0x001DF839 File Offset: 0x001DDA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayStateListRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.instLevelPlayStateReqs_.Add(other.instLevelPlayStateReqs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB29 RID: 52009 RVA: 0x001DF867 File Offset: 0x001DDA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB2A RID: 52010 RVA: 0x001DF870 File Offset: 0x001DDA70
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.instLevelPlayStateReqs_.AddEntriesFrom(ref input, LevelPlayStateListRequest._repeated_instLevelPlayStateReqs_codec);
				}
			}
		}

		// Token: 0x0400569F RID: 22175
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056A0 RID: 22176
		public const int InstLevelPlayStateReqsFieldNumber = 4;

		// Token: 0x040056A1 RID: 22177
		private static readonly FieldCodec<InstLevelPlayStateReq> _repeated_instLevelPlayStateReqs_codec = FieldCodec.ForMessage<InstLevelPlayStateReq>(34U, InstLevelPlayStateReq.Parser);

		// Token: 0x040056A2 RID: 22178
		private readonly RepeatedField<InstLevelPlayStateReq> instLevelPlayStateReqs_ = new RepeatedField<InstLevelPlayStateReq>();
	}
}
