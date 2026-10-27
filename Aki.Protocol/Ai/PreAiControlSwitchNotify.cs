using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016BA RID: 5818
	[NetMessage(EMessageId.PreAiControlSwitchNotify)]
	public sealed class PreAiControlSwitchNotify : IMessage<PreAiControlSwitchNotify>, IMessage, IEquatable<PreAiControlSwitchNotify>, IDeepCloneable<PreAiControlSwitchNotify>, IBufferMessage
	{
		// Token: 0x0601D259 RID: 119385 RVA: 0x004436C3 File Offset: 0x004418C3
		[NullableContext(1)]
		public static PreAiControlSwitchNotify Create()
		{
			return new PreAiControlSwitchNotify();
		}

		// Token: 0x170062DE RID: 25310
		// (get) Token: 0x0601D25A RID: 119386 RVA: 0x004436CA File Offset: 0x004418CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062DF RID: 25311
		// (get) Token: 0x0601D25B RID: 119387 RVA: 0x004436CD File Offset: 0x004418CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreAiControlSwitchNotify.Descriptor;
			}
		}

		// Token: 0x0601D25C RID: 119388 RVA: 0x004436D4 File Offset: 0x004418D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreAiControlSwitchNotify()
		{
		}

		// Token: 0x0601D25D RID: 119389 RVA: 0x004436E7 File Offset: 0x004418E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreAiControlSwitchNotify(PreAiControlSwitchNotify other) : this()
		{
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D25E RID: 119390 RVA: 0x00443711 File Offset: 0x00441911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreAiControlSwitchNotify Clone()
		{
			return new PreAiControlSwitchNotify(this);
		}

		// Token: 0x170062E0 RID: 25312
		// (get) Token: 0x0601D25F RID: 119391 RVA: 0x00443719 File Offset: 0x00441919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0601D260 RID: 119392 RVA: 0x00443721 File Offset: 0x00441921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreAiControlSwitchNotify);
		}

		// Token: 0x0601D261 RID: 119393 RVA: 0x0044372F File Offset: 0x0044192F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreAiControlSwitchNotify other)
		{
			return other != null && (other == this || (this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D262 RID: 119394 RVA: 0x00443764 File Offset: 0x00441964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D263 RID: 119395 RVA: 0x00443798 File Offset: 0x00441998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D264 RID: 119396 RVA: 0x004437A5 File Offset: 0x004419A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D265 RID: 119397 RVA: 0x004437AE File Offset: 0x004419AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, PreAiControlSwitchNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D266 RID: 119398 RVA: 0x004437D8 File Offset: 0x004419D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityIds_.CalculateSize(PreAiControlSwitchNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D267 RID: 119399 RVA: 0x00443811 File Offset: 0x00441A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreAiControlSwitchNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D268 RID: 119400 RVA: 0x0044383F File Offset: 0x00441A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D269 RID: 119401 RVA: 0x00443848 File Offset: 0x00441A48
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, PreAiControlSwitchNotify._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x0400C472 RID: 50290
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C473 RID: 50291
		public const int EntityIdsFieldNumber = 12;

		// Token: 0x0400C474 RID: 50292
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(98U);

		// Token: 0x0400C475 RID: 50293
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
