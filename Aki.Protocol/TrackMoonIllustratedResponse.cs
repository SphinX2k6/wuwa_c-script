using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E6 RID: 5094
	[NetMessage(EMessageId.TrackMoonIllustratedResponse)]
	public sealed class TrackMoonIllustratedResponse : IMessage<TrackMoonIllustratedResponse>, IMessage, IEquatable<TrackMoonIllustratedResponse>, IDeepCloneable<TrackMoonIllustratedResponse>, IBufferMessage
	{
		// Token: 0x0601AFFD RID: 110589 RVA: 0x003E914D File Offset: 0x003E734D
		[NullableContext(1)]
		public static TrackMoonIllustratedResponse Create()
		{
			return new TrackMoonIllustratedResponse();
		}

		// Token: 0x17005AFF RID: 23295
		// (get) Token: 0x0601AFFE RID: 110590 RVA: 0x003E9154 File Offset: 0x003E7354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B00 RID: 23296
		// (get) Token: 0x0601AFFF RID: 110591 RVA: 0x003E9157 File Offset: 0x003E7357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonIllustratedResponse.Descriptor;
			}
		}

		// Token: 0x0601B000 RID: 110592 RVA: 0x003E915E File Offset: 0x003E735E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedResponse()
		{
		}

		// Token: 0x0601B001 RID: 110593 RVA: 0x003E9171 File Offset: 0x003E7371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedResponse(TrackMoonIllustratedResponse other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B002 RID: 110594 RVA: 0x003E919B File Offset: 0x003E739B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonIllustratedResponse Clone()
		{
			return new TrackMoonIllustratedResponse(this);
		}

		// Token: 0x17005B01 RID: 23297
		// (get) Token: 0x0601B003 RID: 110595 RVA: 0x003E91A3 File Offset: 0x003E73A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601B004 RID: 110596 RVA: 0x003E91AB File Offset: 0x003E73AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonIllustratedResponse);
		}

		// Token: 0x0601B005 RID: 110597 RVA: 0x003E91B9 File Offset: 0x003E73B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonIllustratedResponse other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B006 RID: 110598 RVA: 0x003E91EC File Offset: 0x003E73EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B007 RID: 110599 RVA: 0x003E9220 File Offset: 0x003E7420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B008 RID: 110600 RVA: 0x003E922D File Offset: 0x003E742D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B009 RID: 110601 RVA: 0x003E9236 File Offset: 0x003E7436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TrackMoonIllustratedResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B00A RID: 110602 RVA: 0x003E9260 File Offset: 0x003E7460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(TrackMoonIllustratedResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B00B RID: 110603 RVA: 0x003E9299 File Offset: 0x003E7499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonIllustratedResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B00C RID: 110604 RVA: 0x003E92C7 File Offset: 0x003E74C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B00D RID: 110605 RVA: 0x003E92D0 File Offset: 0x003E74D0
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TrackMoonIllustratedResponse._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009C55 RID: 40021
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C56 RID: 40022
		public const int IdsFieldNumber = 2;

		// Token: 0x04009C57 RID: 40023
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009C58 RID: 40024
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
