using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000851 RID: 2129
	public sealed class JoinInfluenceSyncDataPb : IMessage<JoinInfluenceSyncDataPb>, IMessage, IEquatable<JoinInfluenceSyncDataPb>, IDeepCloneable<JoinInfluenceSyncDataPb>, IBufferMessage
	{
		// Token: 0x0600BE25 RID: 48677 RVA: 0x001C42FC File Offset: 0x001C24FC
		[NullableContext(1)]
		public static JoinInfluenceSyncDataPb Create()
		{
			return new JoinInfluenceSyncDataPb();
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x0600BE26 RID: 48678 RVA: 0x001C4303 File Offset: 0x001C2503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x0600BE27 RID: 48679 RVA: 0x001C4306 File Offset: 0x001C2506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinInfluenceSyncDataPb.Descriptor;
			}
		}

		// Token: 0x0600BE28 RID: 48680 RVA: 0x001C430D File Offset: 0x001C250D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinInfluenceSyncDataPb()
		{
		}

		// Token: 0x0600BE29 RID: 48681 RVA: 0x001C4320 File Offset: 0x001C2520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinInfluenceSyncDataPb(JoinInfluenceSyncDataPb other) : this()
		{
			this.influenceId_ = other.influenceId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE2A RID: 48682 RVA: 0x001C434A File Offset: 0x001C254A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinInfluenceSyncDataPb Clone()
		{
			return new JoinInfluenceSyncDataPb(this);
		}

		// Token: 0x17002664 RID: 9828
		// (get) Token: 0x0600BE2B RID: 48683 RVA: 0x001C4352 File Offset: 0x001C2552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> InfluenceId
		{
			get
			{
				return this.influenceId_;
			}
		}

		// Token: 0x0600BE2C RID: 48684 RVA: 0x001C435A File Offset: 0x001C255A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinInfluenceSyncDataPb);
		}

		// Token: 0x0600BE2D RID: 48685 RVA: 0x001C4368 File Offset: 0x001C2568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JoinInfluenceSyncDataPb other)
		{
			return other != null && (other == this || (this.influenceId_.Equals(other.influenceId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE2E RID: 48686 RVA: 0x001C439C File Offset: 0x001C259C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.influenceId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BE2F RID: 48687 RVA: 0x001C43D0 File Offset: 0x001C25D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE30 RID: 48688 RVA: 0x001C43DD File Offset: 0x001C25DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE31 RID: 48689 RVA: 0x001C43E6 File Offset: 0x001C25E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.influenceId_.WriteTo(ref output, JoinInfluenceSyncDataPb._repeated_influenceId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE32 RID: 48690 RVA: 0x001C4410 File Offset: 0x001C2610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.influenceId_.CalculateSize(JoinInfluenceSyncDataPb._repeated_influenceId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE33 RID: 48691 RVA: 0x001C4449 File Offset: 0x001C2649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JoinInfluenceSyncDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.influenceId_.Add(other.influenceId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE34 RID: 48692 RVA: 0x001C4477 File Offset: 0x001C2677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE35 RID: 48693 RVA: 0x001C4480 File Offset: 0x001C2680
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.influenceId_.AddEntriesFrom(ref input, JoinInfluenceSyncDataPb._repeated_influenceId_codec);
				}
			}
		}

		// Token: 0x04005352 RID: 21330
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005353 RID: 21331
		public const int InfluenceIdFieldNumber = 1;

		// Token: 0x04005354 RID: 21332
		private static readonly FieldCodec<int> _repeated_influenceId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04005355 RID: 21333
		private readonly RepeatedField<int> influenceId_ = new RepeatedField<int>();
	}
}
