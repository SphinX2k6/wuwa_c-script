using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001515 RID: 5397
	[NetMessage(EMessageId.WorldBlackboardNotify)]
	public sealed class WorldBlackboardNotify : IMessage<WorldBlackboardNotify>, IMessage, IEquatable<WorldBlackboardNotify>, IDeepCloneable<WorldBlackboardNotify>, IBufferMessage
	{
		// Token: 0x0601C857 RID: 116823 RVA: 0x0041E65A File Offset: 0x0041C85A
		[NullableContext(1)]
		public static WorldBlackboardNotify Create()
		{
			return new WorldBlackboardNotify();
		}

		// Token: 0x17006024 RID: 24612
		// (get) Token: 0x0601C858 RID: 116824 RVA: 0x0041E661 File Offset: 0x0041C861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006025 RID: 24613
		// (get) Token: 0x0601C859 RID: 116825 RVA: 0x0041E664 File Offset: 0x0041C864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldBlackboardNotify.Descriptor;
			}
		}

		// Token: 0x0601C85A RID: 116826 RVA: 0x0041E66B File Offset: 0x0041C86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardNotify()
		{
		}

		// Token: 0x0601C85B RID: 116827 RVA: 0x0041E67E File Offset: 0x0041C87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardNotify(WorldBlackboardNotify other) : this()
		{
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C85C RID: 116828 RVA: 0x0041E6A8 File Offset: 0x0041C8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardNotify Clone()
		{
			return new WorldBlackboardNotify(this);
		}

		// Token: 0x17006026 RID: 24614
		// (get) Token: 0x0601C85D RID: 116829 RVA: 0x0041E6B0 File Offset: 0x0041C8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x0601C85E RID: 116830 RVA: 0x0041E6B8 File Offset: 0x0041C8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldBlackboardNotify);
		}

		// Token: 0x0601C85F RID: 116831 RVA: 0x0041E6C6 File Offset: 0x0041C8C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldBlackboardNotify other)
		{
			return other != null && (other == this || (this.params_.Equals(other.params_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C860 RID: 116832 RVA: 0x0041E6FC File Offset: 0x0041C8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.params_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C861 RID: 116833 RVA: 0x0041E730 File Offset: 0x0041C930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C862 RID: 116834 RVA: 0x0041E73D File Offset: 0x0041C93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C863 RID: 116835 RVA: 0x0041E746 File Offset: 0x0041C946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.params_.WriteTo(ref output, WorldBlackboardNotify._repeated_params_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C864 RID: 116836 RVA: 0x0041E770 File Offset: 0x0041C970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.params_.CalculateSize(WorldBlackboardNotify._repeated_params_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C865 RID: 116837 RVA: 0x0041E7A9 File Offset: 0x0041C9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldBlackboardNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.params_.Add(other.params_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C866 RID: 116838 RVA: 0x0041E7D7 File Offset: 0x0041C9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C867 RID: 116839 RVA: 0x0041E7E0 File Offset: 0x0041C9E0
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.params_.AddEntriesFrom(ref input, WorldBlackboardNotify._repeated_params_codec);
				}
			}
		}

		// Token: 0x0400A32A RID: 41770
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A32B RID: 41771
		public const int ParamsFieldNumber = 5;

		// Token: 0x0400A32C RID: 41772
		private static readonly FieldCodec<BlackboardParam> _repeated_params_codec = FieldCodec.ForMessage<BlackboardParam>(42U, BlackboardParam.Parser);

		// Token: 0x0400A32D RID: 41773
		private readonly RepeatedField<BlackboardParam> params_ = new RepeatedField<BlackboardParam>();
	}
}
