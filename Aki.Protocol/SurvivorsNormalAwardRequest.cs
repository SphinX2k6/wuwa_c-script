using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001342 RID: 4930
	[NetMessage(EMessageId.SurvivorsNormalAwardRequest)]
	public sealed class SurvivorsNormalAwardRequest : IMessage<SurvivorsNormalAwardRequest>, IMessage, IEquatable<SurvivorsNormalAwardRequest>, IDeepCloneable<SurvivorsNormalAwardRequest>, IBufferMessage
	{
		// Token: 0x0601A465 RID: 107621 RVA: 0x003D46D8 File Offset: 0x003D28D8
		[NullableContext(1)]
		public static SurvivorsNormalAwardRequest Create()
		{
			return new SurvivorsNormalAwardRequest();
		}

		// Token: 0x170058FC RID: 22780
		// (get) Token: 0x0601A466 RID: 107622 RVA: 0x003D46DF File Offset: 0x003D28DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058FD RID: 22781
		// (get) Token: 0x0601A467 RID: 107623 RVA: 0x003D46E2 File Offset: 0x003D28E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsNormalAwardRequest.Descriptor;
			}
		}

		// Token: 0x0601A468 RID: 107624 RVA: 0x003D46E9 File Offset: 0x003D28E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsNormalAwardRequest()
		{
		}

		// Token: 0x0601A469 RID: 107625 RVA: 0x003D46FC File Offset: 0x003D28FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsNormalAwardRequest(SurvivorsNormalAwardRequest other) : this()
		{
			this.configs_ = other.configs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A46A RID: 107626 RVA: 0x003D4726 File Offset: 0x003D2926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsNormalAwardRequest Clone()
		{
			return new SurvivorsNormalAwardRequest(this);
		}

		// Token: 0x170058FE RID: 22782
		// (get) Token: 0x0601A46B RID: 107627 RVA: 0x003D472E File Offset: 0x003D292E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Configs
		{
			get
			{
				return this.configs_;
			}
		}

		// Token: 0x0601A46C RID: 107628 RVA: 0x003D4736 File Offset: 0x003D2936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsNormalAwardRequest);
		}

		// Token: 0x0601A46D RID: 107629 RVA: 0x003D4744 File Offset: 0x003D2944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsNormalAwardRequest other)
		{
			return other != null && (other == this || (this.configs_.Equals(other.configs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A46E RID: 107630 RVA: 0x003D4778 File Offset: 0x003D2978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.configs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A46F RID: 107631 RVA: 0x003D47AC File Offset: 0x003D29AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A470 RID: 107632 RVA: 0x003D47B9 File Offset: 0x003D29B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A471 RID: 107633 RVA: 0x003D47C2 File Offset: 0x003D29C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.configs_.WriteTo(ref output, SurvivorsNormalAwardRequest._repeated_configs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A472 RID: 107634 RVA: 0x003D47EC File Offset: 0x003D29EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.configs_.CalculateSize(SurvivorsNormalAwardRequest._repeated_configs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A473 RID: 107635 RVA: 0x003D4825 File Offset: 0x003D2A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsNormalAwardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.configs_.Add(other.configs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A474 RID: 107636 RVA: 0x003D4853 File Offset: 0x003D2A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A475 RID: 107637 RVA: 0x003D485C File Offset: 0x003D2A5C
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.configs_.AddEntriesFrom(ref input, SurvivorsNormalAwardRequest._repeated_configs_codec);
				}
			}
		}

		// Token: 0x04009A7B RID: 39547
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A7C RID: 39548
		public const int ConfigsFieldNumber = 8;

		// Token: 0x04009A7D RID: 39549
		private static readonly FieldCodec<int> _repeated_configs_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04009A7E RID: 39550
		private readonly RepeatedField<int> configs_ = new RepeatedField<int>();
	}
}
