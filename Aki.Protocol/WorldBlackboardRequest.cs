using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200158C RID: 5516
	[NetMessage(EMessageId.WorldBlackboardRequest)]
	public sealed class WorldBlackboardRequest : IMessage<WorldBlackboardRequest>, IMessage, IEquatable<WorldBlackboardRequest>, IDeepCloneable<WorldBlackboardRequest>, IBufferMessage
	{
		// Token: 0x0601D330 RID: 119600 RVA: 0x0043A2FD File Offset: 0x004384FD
		[NullableContext(1)]
		public static WorldBlackboardRequest Create()
		{
			return new WorldBlackboardRequest();
		}

		// Token: 0x170062C8 RID: 25288
		// (get) Token: 0x0601D331 RID: 119601 RVA: 0x0043A304 File Offset: 0x00438504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062C9 RID: 25289
		// (get) Token: 0x0601D332 RID: 119602 RVA: 0x0043A307 File Offset: 0x00438507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldBlackboardRequest.Descriptor;
			}
		}

		// Token: 0x0601D333 RID: 119603 RVA: 0x0043A30E File Offset: 0x0043850E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardRequest()
		{
		}

		// Token: 0x0601D334 RID: 119604 RVA: 0x0043A321 File Offset: 0x00438521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardRequest(WorldBlackboardRequest other) : this()
		{
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D335 RID: 119605 RVA: 0x0043A34B File Offset: 0x0043854B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardRequest Clone()
		{
			return new WorldBlackboardRequest(this);
		}

		// Token: 0x170062CA RID: 25290
		// (get) Token: 0x0601D336 RID: 119606 RVA: 0x0043A353 File Offset: 0x00438553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x0601D337 RID: 119607 RVA: 0x0043A35B File Offset: 0x0043855B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldBlackboardRequest);
		}

		// Token: 0x0601D338 RID: 119608 RVA: 0x0043A369 File Offset: 0x00438569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldBlackboardRequest other)
		{
			return other != null && (other == this || (this.params_.Equals(other.params_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D339 RID: 119609 RVA: 0x0043A39C File Offset: 0x0043859C
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

		// Token: 0x0601D33A RID: 119610 RVA: 0x0043A3D0 File Offset: 0x004385D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D33B RID: 119611 RVA: 0x0043A3DD File Offset: 0x004385DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D33C RID: 119612 RVA: 0x0043A3E6 File Offset: 0x004385E6
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

		// Token: 0x0601D33D RID: 119613 RVA: 0x0043A410 File Offset: 0x00438610
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

		// Token: 0x0601D33E RID: 119614 RVA: 0x0043A449 File Offset: 0x00438649
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

		// Token: 0x0601D33F RID: 119615 RVA: 0x0043A477 File Offset: 0x00438677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D340 RID: 119616 RVA: 0x0043A480 File Offset: 0x00438680
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.params_.AddEntriesFrom(ref input, WorldBlackboardRequest._repeated_params_codec);
				}
			}
		}

		// Token: 0x0400A787 RID: 42887
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A788 RID: 42888
		public const int ParamsFieldNumber = 10;

		// Token: 0x0400A789 RID: 42889
		private static readonly FieldCodec<BlackboardParam> _repeated_params_codec = FieldCodec.ForMessage<BlackboardParam>(82U, BlackboardParam.Parser);

		// Token: 0x0400A78A RID: 42890
		private readonly RepeatedField<BlackboardParam> params_ = new RepeatedField<BlackboardParam>();
	}
}
