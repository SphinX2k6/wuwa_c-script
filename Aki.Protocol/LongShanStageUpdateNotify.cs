using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000944 RID: 2372
	[NetMessage(EMessageId.LongShanStageUpdateNotify)]
	public sealed class LongShanStageUpdateNotify : IMessage<LongShanStageUpdateNotify>, IMessage, IEquatable<LongShanStageUpdateNotify>, IDeepCloneable<LongShanStageUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600D174 RID: 53620 RVA: 0x001EE693 File Offset: 0x001EC893
		[NullableContext(1)]
		public static LongShanStageUpdateNotify Create()
		{
			return new LongShanStageUpdateNotify();
		}

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x0600D175 RID: 53621 RVA: 0x001EE69A File Offset: 0x001EC89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x0600D176 RID: 53622 RVA: 0x001EE69D File Offset: 0x001EC89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanStageUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600D177 RID: 53623 RVA: 0x001EE6A4 File Offset: 0x001EC8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanStageUpdateNotify()
		{
		}

		// Token: 0x0600D178 RID: 53624 RVA: 0x001EE6B7 File Offset: 0x001EC8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanStageUpdateNotify(LongShanStageUpdateNotify other) : this()
		{
			this.stages_ = other.stages_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D179 RID: 53625 RVA: 0x001EE6E1 File Offset: 0x001EC8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanStageUpdateNotify Clone()
		{
			return new LongShanStageUpdateNotify(this);
		}

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x0600D17A RID: 53626 RVA: 0x001EE6E9 File Offset: 0x001EC8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LongShanStageInfo> Stages
		{
			get
			{
				return this.stages_;
			}
		}

		// Token: 0x0600D17B RID: 53627 RVA: 0x001EE6F1 File Offset: 0x001EC8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanStageUpdateNotify);
		}

		// Token: 0x0600D17C RID: 53628 RVA: 0x001EE6FF File Offset: 0x001EC8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanStageUpdateNotify other)
		{
			return other != null && (other == this || (this.stages_.Equals(other.stages_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D17D RID: 53629 RVA: 0x001EE734 File Offset: 0x001EC934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.stages_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D17E RID: 53630 RVA: 0x001EE768 File Offset: 0x001EC968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D17F RID: 53631 RVA: 0x001EE775 File Offset: 0x001EC975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D180 RID: 53632 RVA: 0x001EE77E File Offset: 0x001EC97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stages_.WriteTo(ref output, LongShanStageUpdateNotify._repeated_stages_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D181 RID: 53633 RVA: 0x001EE7A8 File Offset: 0x001EC9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stages_.CalculateSize(LongShanStageUpdateNotify._repeated_stages_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D182 RID: 53634 RVA: 0x001EE7E1 File Offset: 0x001EC9E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanStageUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.stages_.Add(other.stages_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D183 RID: 53635 RVA: 0x001EE80F File Offset: 0x001ECA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D184 RID: 53636 RVA: 0x001EE818 File Offset: 0x001ECA18
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.stages_.AddEntriesFrom(ref input, LongShanStageUpdateNotify._repeated_stages_codec);
				}
			}
		}

		// Token: 0x0400589D RID: 22685
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400589E RID: 22686
		public const int StagesFieldNumber = 8;

		// Token: 0x0400589F RID: 22687
		private static readonly FieldCodec<LongShanStageInfo> _repeated_stages_codec = FieldCodec.ForMessage<LongShanStageInfo>(66U, LongShanStageInfo.Parser);

		// Token: 0x040058A0 RID: 22688
		private readonly RepeatedField<LongShanStageInfo> stages_ = new RepeatedField<LongShanStageInfo>();
	}
}
