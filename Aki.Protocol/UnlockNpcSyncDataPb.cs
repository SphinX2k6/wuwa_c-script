using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001502 RID: 5378
	public sealed class UnlockNpcSyncDataPb : IMessage<UnlockNpcSyncDataPb>, IMessage, IEquatable<UnlockNpcSyncDataPb>, IDeepCloneable<UnlockNpcSyncDataPb>, IBufferMessage
	{
		// Token: 0x0601C810 RID: 116752 RVA: 0x00421EB1 File Offset: 0x004200B1
		[NullableContext(1)]
		public static UnlockNpcSyncDataPb Create()
		{
			return new UnlockNpcSyncDataPb();
		}

		// Token: 0x17006071 RID: 24689
		// (get) Token: 0x0601C811 RID: 116753 RVA: 0x00421EB8 File Offset: 0x004200B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006072 RID: 24690
		// (get) Token: 0x0601C812 RID: 116754 RVA: 0x00421EBB File Offset: 0x004200BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockNpcSyncDataPb.Descriptor;
			}
		}

		// Token: 0x0601C813 RID: 116755 RVA: 0x00421EC2 File Offset: 0x004200C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockNpcSyncDataPb()
		{
		}

		// Token: 0x0601C814 RID: 116756 RVA: 0x00421ED5 File Offset: 0x004200D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockNpcSyncDataPb(UnlockNpcSyncDataPb other) : this()
		{
			this.npcId_ = other.npcId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C815 RID: 116757 RVA: 0x00421EFF File Offset: 0x004200FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockNpcSyncDataPb Clone()
		{
			return new UnlockNpcSyncDataPb(this);
		}

		// Token: 0x17006073 RID: 24691
		// (get) Token: 0x0601C816 RID: 116758 RVA: 0x00421F07 File Offset: 0x00420107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NpcId
		{
			get
			{
				return this.npcId_;
			}
		}

		// Token: 0x0601C817 RID: 116759 RVA: 0x00421F0F File Offset: 0x0042010F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockNpcSyncDataPb);
		}

		// Token: 0x0601C818 RID: 116760 RVA: 0x00421F1D File Offset: 0x0042011D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockNpcSyncDataPb other)
		{
			return other != null && (other == this || (this.npcId_.Equals(other.npcId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C819 RID: 116761 RVA: 0x00421F50 File Offset: 0x00420150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.npcId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C81A RID: 116762 RVA: 0x00421F84 File Offset: 0x00420184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C81B RID: 116763 RVA: 0x00421F91 File Offset: 0x00420191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C81C RID: 116764 RVA: 0x00421F9A File Offset: 0x0042019A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.npcId_.WriteTo(ref output, UnlockNpcSyncDataPb._repeated_npcId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C81D RID: 116765 RVA: 0x00421FC4 File Offset: 0x004201C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.npcId_.CalculateSize(UnlockNpcSyncDataPb._repeated_npcId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C81E RID: 116766 RVA: 0x00421FFD File Offset: 0x004201FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockNpcSyncDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.npcId_.Add(other.npcId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C81F RID: 116767 RVA: 0x0042202B File Offset: 0x0042022B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C820 RID: 116768 RVA: 0x00422034 File Offset: 0x00420234
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
					this.npcId_.AddEntriesFrom(ref input, UnlockNpcSyncDataPb._repeated_npcId_codec);
				}
			}
		}

		// Token: 0x0400A46B RID: 42091
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A46C RID: 42092
		public const int NpcIdFieldNumber = 1;

		// Token: 0x0400A46D RID: 42093
		private static readonly FieldCodec<int> _repeated_npcId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400A46E RID: 42094
		private readonly RepeatedField<int> npcId_ = new RepeatedField<int>();
	}
}
