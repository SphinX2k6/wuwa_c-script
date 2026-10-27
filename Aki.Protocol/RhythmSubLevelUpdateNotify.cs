using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F4E RID: 3918
	[NetMessage(EMessageId.RhythmSubLevelUpdateNotify)]
	public sealed class RhythmSubLevelUpdateNotify : IMessage<RhythmSubLevelUpdateNotify>, IMessage, IEquatable<RhythmSubLevelUpdateNotify>, IDeepCloneable<RhythmSubLevelUpdateNotify>, IBufferMessage
	{
		// Token: 0x06014F69 RID: 85865 RVA: 0x0030AACE File Offset: 0x00308CCE
		[NullableContext(1)]
		public static RhythmSubLevelUpdateNotify Create()
		{
			return new RhythmSubLevelUpdateNotify();
		}

		// Token: 0x170045BC RID: 17852
		// (get) Token: 0x06014F6A RID: 85866 RVA: 0x0030AAD5 File Offset: 0x00308CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045BD RID: 17853
		// (get) Token: 0x06014F6B RID: 85867 RVA: 0x0030AAD8 File Offset: 0x00308CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmSubLevelUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06014F6C RID: 85868 RVA: 0x0030AADF File Offset: 0x00308CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSubLevelUpdateNotify()
		{
		}

		// Token: 0x06014F6D RID: 85869 RVA: 0x0030AAF2 File Offset: 0x00308CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSubLevelUpdateNotify(RhythmSubLevelUpdateNotify other) : this()
		{
			this.updateSubLevelPb_ = other.updateSubLevelPb_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F6E RID: 85870 RVA: 0x0030AB1C File Offset: 0x00308D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSubLevelUpdateNotify Clone()
		{
			return new RhythmSubLevelUpdateNotify(this);
		}

		// Token: 0x170045BE RID: 17854
		// (get) Token: 0x06014F6F RID: 85871 RVA: 0x0030AB24 File Offset: 0x00308D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmSubLevelPb> UpdateSubLevelPb
		{
			get
			{
				return this.updateSubLevelPb_;
			}
		}

		// Token: 0x06014F70 RID: 85872 RVA: 0x0030AB2C File Offset: 0x00308D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmSubLevelUpdateNotify);
		}

		// Token: 0x06014F71 RID: 85873 RVA: 0x0030AB3A File Offset: 0x00308D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmSubLevelUpdateNotify other)
		{
			return other != null && (other == this || (this.updateSubLevelPb_.Equals(other.updateSubLevelPb_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F72 RID: 85874 RVA: 0x0030AB70 File Offset: 0x00308D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.updateSubLevelPb_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014F73 RID: 85875 RVA: 0x0030ABA4 File Offset: 0x00308DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F74 RID: 85876 RVA: 0x0030ABB1 File Offset: 0x00308DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F75 RID: 85877 RVA: 0x0030ABBA File Offset: 0x00308DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updateSubLevelPb_.WriteTo(ref output, RhythmSubLevelUpdateNotify._repeated_updateSubLevelPb_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014F76 RID: 85878 RVA: 0x0030ABE4 File Offset: 0x00308DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.updateSubLevelPb_.CalculateSize(RhythmSubLevelUpdateNotify._repeated_updateSubLevelPb_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014F77 RID: 85879 RVA: 0x0030AC1D File Offset: 0x00308E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmSubLevelUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.updateSubLevelPb_.Add(other.updateSubLevelPb_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014F78 RID: 85880 RVA: 0x0030AC4B File Offset: 0x00308E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F79 RID: 85881 RVA: 0x0030AC54 File Offset: 0x00308E54
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.updateSubLevelPb_.AddEntriesFrom(ref input, RhythmSubLevelUpdateNotify._repeated_updateSubLevelPb_codec);
				}
			}
		}

		// Token: 0x04007E65 RID: 32357
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E66 RID: 32358
		public const int UpdateSubLevelPbFieldNumber = 14;

		// Token: 0x04007E67 RID: 32359
		private static readonly FieldCodec<RhythmSubLevelPb> _repeated_updateSubLevelPb_codec = FieldCodec.ForMessage<RhythmSubLevelPb>(114U, RhythmSubLevelPb.Parser);

		// Token: 0x04007E68 RID: 32360
		private readonly RepeatedField<RhythmSubLevelPb> updateSubLevelPb_ = new RepeatedField<RhythmSubLevelPb>();
	}
}
