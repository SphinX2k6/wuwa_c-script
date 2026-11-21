using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200092F RID: 2351
	[NetMessage(EMessageId.LoadingLevelAreaResponse)]
	public sealed class LoadingLevelAreaResponse : IMessage<LoadingLevelAreaResponse>, IMessage, IEquatable<LoadingLevelAreaResponse>, IDeepCloneable<LoadingLevelAreaResponse>, IBufferMessage
	{
		// Token: 0x0600CF80 RID: 53120 RVA: 0x001E8DD2 File Offset: 0x001E6FD2
		[NullableContext(1)]
		public static LoadingLevelAreaResponse Create()
		{
			return new LoadingLevelAreaResponse();
		}

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x0600CF81 RID: 53121 RVA: 0x001E8DD9 File Offset: 0x001E6FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x0600CF82 RID: 53122 RVA: 0x001E8DDC File Offset: 0x001E6FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadingLevelAreaResponse.Descriptor;
			}
		}

		// Token: 0x0600CF83 RID: 53123 RVA: 0x001E8DE3 File Offset: 0x001E6FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingLevelAreaResponse()
		{
		}

		// Token: 0x0600CF84 RID: 53124 RVA: 0x001E8DF6 File Offset: 0x001E6FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingLevelAreaResponse(LoadingLevelAreaResponse other) : this()
		{
			this.limitConfigs_ = other.limitConfigs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF85 RID: 53125 RVA: 0x001E8E20 File Offset: 0x001E7020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingLevelAreaResponse Clone()
		{
			return new LoadingLevelAreaResponse(this);
		}

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x0600CF86 RID: 53126 RVA: 0x001E8E28 File Offset: 0x001E7028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LoadingAreaConfig> LimitConfigs
		{
			get
			{
				return this.limitConfigs_;
			}
		}

		// Token: 0x0600CF87 RID: 53127 RVA: 0x001E8E30 File Offset: 0x001E7030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadingLevelAreaResponse);
		}

		// Token: 0x0600CF88 RID: 53128 RVA: 0x001E8E3E File Offset: 0x001E703E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadingLevelAreaResponse other)
		{
			return other != null && (other == this || (this.limitConfigs_.Equals(other.limitConfigs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF89 RID: 53129 RVA: 0x001E8E74 File Offset: 0x001E7074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.limitConfigs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CF8A RID: 53130 RVA: 0x001E8EA8 File Offset: 0x001E70A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF8B RID: 53131 RVA: 0x001E8EB5 File Offset: 0x001E70B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF8C RID: 53132 RVA: 0x001E8EBE File Offset: 0x001E70BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.limitConfigs_.WriteTo(ref output, LoadingLevelAreaResponse._repeated_limitConfigs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF8D RID: 53133 RVA: 0x001E8EE8 File Offset: 0x001E70E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.limitConfigs_.CalculateSize(LoadingLevelAreaResponse._repeated_limitConfigs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CF8E RID: 53134 RVA: 0x001E8F21 File Offset: 0x001E7121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoadingLevelAreaResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.limitConfigs_.Add(other.limitConfigs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF8F RID: 53135 RVA: 0x001E8F4F File Offset: 0x001E714F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF90 RID: 53136 RVA: 0x001E8F58 File Offset: 0x001E7158
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
					this.limitConfigs_.AddEntriesFrom(ref input, LoadingLevelAreaResponse._repeated_limitConfigs_codec);
				}
			}
		}

		// Token: 0x040057DA RID: 22490
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057DB RID: 22491
		public const int LimitConfigsFieldNumber = 2;

		// Token: 0x040057DC RID: 22492
		private static readonly FieldCodec<LoadingAreaConfig> _repeated_limitConfigs_codec = FieldCodec.ForMessage<LoadingAreaConfig>(18U, LoadingAreaConfig.Parser);

		// Token: 0x040057DD RID: 22493
		private readonly RepeatedField<LoadingAreaConfig> limitConfigs_ = new RepeatedField<LoadingAreaConfig>();
	}
}
