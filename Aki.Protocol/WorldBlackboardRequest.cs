using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001516 RID: 5398
	[NetMessage(EMessageId.WorldBlackboardRequest)]
	public sealed class WorldBlackboardRequest : IMessage<WorldBlackboardRequest>, IMessage, IEquatable<WorldBlackboardRequest>, IDeepCloneable<WorldBlackboardRequest>, IBufferMessage
	{
		// Token: 0x0601C869 RID: 116841 RVA: 0x0041E83D File Offset: 0x0041CA3D
		[NullableContext(1)]
		public static WorldBlackboardRequest Create()
		{
			return new WorldBlackboardRequest();
		}

		// Token: 0x17006027 RID: 24615
		// (get) Token: 0x0601C86A RID: 116842 RVA: 0x0041E844 File Offset: 0x0041CA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006028 RID: 24616
		// (get) Token: 0x0601C86B RID: 116843 RVA: 0x0041E847 File Offset: 0x0041CA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldBlackboardRequest.Descriptor;
			}
		}

		// Token: 0x0601C86C RID: 116844 RVA: 0x0041E84E File Offset: 0x0041CA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardRequest()
		{
		}

		// Token: 0x0601C86D RID: 116845 RVA: 0x0041E861 File Offset: 0x0041CA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardRequest(WorldBlackboardRequest other) : this()
		{
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C86E RID: 116846 RVA: 0x0041E88B File Offset: 0x0041CA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardRequest Clone()
		{
			return new WorldBlackboardRequest(this);
		}

		// Token: 0x17006029 RID: 24617
		// (get) Token: 0x0601C86F RID: 116847 RVA: 0x0041E893 File Offset: 0x0041CA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x0601C870 RID: 116848 RVA: 0x0041E89B File Offset: 0x0041CA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldBlackboardRequest);
		}

		// Token: 0x0601C871 RID: 116849 RVA: 0x0041E8A9 File Offset: 0x0041CAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldBlackboardRequest other)
		{
			return other != null && (other == this || (this.params_.Equals(other.params_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C872 RID: 116850 RVA: 0x0041E8DC File Offset: 0x0041CADC
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

		// Token: 0x0601C873 RID: 116851 RVA: 0x0041E910 File Offset: 0x0041CB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C874 RID: 116852 RVA: 0x0041E91D File Offset: 0x0041CB1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C875 RID: 116853 RVA: 0x0041E926 File Offset: 0x0041CB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.params_.WriteTo(ref output, WorldBlackboardRequest._repeated_params_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C876 RID: 116854 RVA: 0x0041E950 File Offset: 0x0041CB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.params_.CalculateSize(WorldBlackboardRequest._repeated_params_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C877 RID: 116855 RVA: 0x0041E989 File Offset: 0x0041CB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldBlackboardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.params_.Add(other.params_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C878 RID: 116856 RVA: 0x0041E9B7 File Offset: 0x0041CBB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C879 RID: 116857 RVA: 0x0041E9C0 File Offset: 0x0041CBC0
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.params_.AddEntriesFrom(ref input, WorldBlackboardRequest._repeated_params_codec);
				}
			}
		}

		// Token: 0x0400A32E RID: 41774
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A32F RID: 41775
		public const int ParamsFieldNumber = 15;

		// Token: 0x0400A330 RID: 41776
		private static readonly FieldCodec<BlackboardParam> _repeated_params_codec = FieldCodec.ForMessage<BlackboardParam>(122U, BlackboardParam.Parser);

		// Token: 0x0400A331 RID: 41777
		private readonly RepeatedField<BlackboardParam> params_ = new RepeatedField<BlackboardParam>();
	}
}
