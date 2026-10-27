using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B7 RID: 1719
	public sealed class GatherActivityInfo : IMessage<GatherActivityInfo>, IMessage, IEquatable<GatherActivityInfo>, IDeepCloneable<GatherActivityInfo>, IBufferMessage
	{
		// Token: 0x06009D84 RID: 40324 RVA: 0x0017ED89 File Offset: 0x0017CF89
		[NullableContext(1)]
		public static GatherActivityInfo Create()
		{
			return new GatherActivityInfo();
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x06009D85 RID: 40325 RVA: 0x0017ED90 File Offset: 0x0017CF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06009D86 RID: 40326 RVA: 0x0017ED93 File Offset: 0x0017CF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherActivityInfo.Descriptor;
			}
		}

		// Token: 0x06009D87 RID: 40327 RVA: 0x0017ED9A File Offset: 0x0017CF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityInfo()
		{
		}

		// Token: 0x06009D88 RID: 40328 RVA: 0x0017EDAD File Offset: 0x0017CFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityInfo(GatherActivityInfo other) : this()
		{
			this.gatherTaskDoneInfo_ = other.gatherTaskDoneInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D89 RID: 40329 RVA: 0x0017EDD7 File Offset: 0x0017CFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityInfo Clone()
		{
			return new GatherActivityInfo(this);
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06009D8A RID: 40330 RVA: 0x0017EDDF File Offset: 0x0017CFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GatherTaskDoneInfo> GatherTaskDoneInfo
		{
			get
			{
				return this.gatherTaskDoneInfo_;
			}
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x0017EDE7 File Offset: 0x0017CFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherActivityInfo);
		}

		// Token: 0x06009D8C RID: 40332 RVA: 0x0017EDF5 File Offset: 0x0017CFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherActivityInfo other)
		{
			return other != null && (other == this || (this.gatherTaskDoneInfo_.Equals(other.gatherTaskDoneInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D8D RID: 40333 RVA: 0x0017EE28 File Offset: 0x0017D028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gatherTaskDoneInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009D8E RID: 40334 RVA: 0x0017EE5C File Offset: 0x0017D05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D8F RID: 40335 RVA: 0x0017EE69 File Offset: 0x0017D069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D90 RID: 40336 RVA: 0x0017EE72 File Offset: 0x0017D072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gatherTaskDoneInfo_.WriteTo(ref output, GatherActivityInfo._repeated_gatherTaskDoneInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x0017EE9C File Offset: 0x0017D09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gatherTaskDoneInfo_.CalculateSize(GatherActivityInfo._repeated_gatherTaskDoneInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D92 RID: 40338 RVA: 0x0017EED5 File Offset: 0x0017D0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.gatherTaskDoneInfo_.Add(other.gatherTaskDoneInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009D93 RID: 40339 RVA: 0x0017EF03 File Offset: 0x0017D103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D94 RID: 40340 RVA: 0x0017EF0C File Offset: 0x0017D10C
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.gatherTaskDoneInfo_.AddEntriesFrom(ref input, GatherActivityInfo._repeated_gatherTaskDoneInfo_codec);
				}
			}
		}

		// Token: 0x040049FC RID: 18940
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049FD RID: 18941
		public const int GatherTaskDoneInfoFieldNumber = 1;

		// Token: 0x040049FE RID: 18942
		private static readonly FieldCodec<GatherTaskDoneInfo> _repeated_gatherTaskDoneInfo_codec = FieldCodec.ForMessage<GatherTaskDoneInfo>(10U, Aki.Protocol.GatherTaskDoneInfo.Parser);

		// Token: 0x040049FF RID: 18943
		private readonly RepeatedField<GatherTaskDoneInfo> gatherTaskDoneInfo_ = new RepeatedField<GatherTaskDoneInfo>();
	}
}
