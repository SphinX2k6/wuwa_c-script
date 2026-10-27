using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200108E RID: 4238
	[NetMessage(EMessageId.RoleMotionFinishConditionNotify)]
	public sealed class RoleMotionFinishConditionNotify : IMessage<RoleMotionFinishConditionNotify>, IMessage, IEquatable<RoleMotionFinishConditionNotify>, IDeepCloneable<RoleMotionFinishConditionNotify>, IBufferMessage
	{
		// Token: 0x06016A45 RID: 92741 RVA: 0x0034AB34 File Offset: 0x00348D34
		[NullableContext(1)]
		public static RoleMotionFinishConditionNotify Create()
		{
			return new RoleMotionFinishConditionNotify();
		}

		// Token: 0x17004BDB RID: 19419
		// (get) Token: 0x06016A46 RID: 92742 RVA: 0x0034AB3B File Offset: 0x00348D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BDC RID: 19420
		// (get) Token: 0x06016A47 RID: 92743 RVA: 0x0034AB3E File Offset: 0x00348D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotionFinishConditionNotify.Descriptor;
			}
		}

		// Token: 0x06016A48 RID: 92744 RVA: 0x0034AB45 File Offset: 0x00348D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionFinishConditionNotify()
		{
		}

		// Token: 0x06016A49 RID: 92745 RVA: 0x0034AB58 File Offset: 0x00348D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionFinishConditionNotify(RoleMotionFinishConditionNotify other) : this()
		{
			this.roleConditionInfoMap_ = other.roleConditionInfoMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A4A RID: 92746 RVA: 0x0034AB82 File Offset: 0x00348D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionFinishConditionNotify Clone()
		{
			return new RoleMotionFinishConditionNotify(this);
		}

		// Token: 0x17004BDD RID: 19421
		// (get) Token: 0x06016A4B RID: 92747 RVA: 0x0034AB8A File Offset: 0x00348D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ConditionInfo> RoleConditionInfoMap
		{
			get
			{
				return this.roleConditionInfoMap_;
			}
		}

		// Token: 0x06016A4C RID: 92748 RVA: 0x0034AB92 File Offset: 0x00348D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotionFinishConditionNotify);
		}

		// Token: 0x06016A4D RID: 92749 RVA: 0x0034ABA0 File Offset: 0x00348DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotionFinishConditionNotify other)
		{
			return other != null && (other == this || (this.RoleConditionInfoMap.Equals(other.RoleConditionInfoMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A4E RID: 92750 RVA: 0x0034ABD4 File Offset: 0x00348DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.RoleConditionInfoMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016A4F RID: 92751 RVA: 0x0034AC08 File Offset: 0x00348E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A50 RID: 92752 RVA: 0x0034AC15 File Offset: 0x00348E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A51 RID: 92753 RVA: 0x0034AC1E File Offset: 0x00348E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleConditionInfoMap_.WriteTo(ref output, RoleMotionFinishConditionNotify._map_roleConditionInfoMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016A52 RID: 92754 RVA: 0x0034AC48 File Offset: 0x00348E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleConditionInfoMap_.CalculateSize(RoleMotionFinishConditionNotify._map_roleConditionInfoMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016A53 RID: 92755 RVA: 0x0034AC81 File Offset: 0x00348E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleMotionFinishConditionNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleConditionInfoMap_.MergeFrom(other.roleConditionInfoMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016A54 RID: 92756 RVA: 0x0034ACAF File Offset: 0x00348EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A55 RID: 92757 RVA: 0x0034ACB8 File Offset: 0x00348EB8
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleConditionInfoMap_.AddEntriesFrom(ref input, RoleMotionFinishConditionNotify._map_roleConditionInfoMap_codec);
				}
			}
		}

		// Token: 0x04008758 RID: 34648
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008759 RID: 34649
		public const int RoleConditionInfoMapFieldNumber = 2;

		// Token: 0x0400875A RID: 34650
		private static readonly MapField<int, ConditionInfo>.Codec _map_roleConditionInfoMap_codec = new MapField<int, ConditionInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ConditionInfo>(18U, ConditionInfo.Parser), 18U);

		// Token: 0x0400875B RID: 34651
		private readonly MapField<int, ConditionInfo> roleConditionInfoMap_ = new MapField<int, ConditionInfo>();
	}
}
