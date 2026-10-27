using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006FE RID: 1790
	public sealed class GmEntityFsmTransitionInfo : IMessage<GmEntityFsmTransitionInfo>, IMessage, IEquatable<GmEntityFsmTransitionInfo>, IDeepCloneable<GmEntityFsmTransitionInfo>, IBufferMessage
	{
		// Token: 0x0600A2FF RID: 41727 RVA: 0x00189F31 File Offset: 0x00188131
		[NullableContext(1)]
		public static GmEntityFsmTransitionInfo Create()
		{
			return new GmEntityFsmTransitionInfo();
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x0600A300 RID: 41728 RVA: 0x00189F38 File Offset: 0x00188138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GmEntityFsmTransitionInfo> Parser
		{
			get
			{
				return GmEntityFsmTransitionInfo._parser;
			}
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x0600A301 RID: 41729 RVA: 0x00189F3F File Offset: 0x0018813F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x0600A302 RID: 41730 RVA: 0x00189F42 File Offset: 0x00188142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmEntityFsmTransitionInfo.Descriptor;
			}
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x00189F49 File Offset: 0x00188149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmTransitionInfo()
		{
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x00189F5C File Offset: 0x0018815C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmTransitionInfo(GmEntityFsmTransitionInfo other) : this()
		{
			this.toStateIndex_ = other.toStateIndex_;
			this.gmEntityFsmConditions_ = other.gmEntityFsmConditions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x00189F92 File Offset: 0x00188192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmTransitionInfo Clone()
		{
			return new GmEntityFsmTransitionInfo(this);
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x0600A306 RID: 41734 RVA: 0x00189F9A File Offset: 0x0018819A
		// (set) Token: 0x0600A307 RID: 41735 RVA: 0x00189FA2 File Offset: 0x001881A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ToStateIndex
		{
			get
			{
				return this.toStateIndex_;
			}
			set
			{
				this.toStateIndex_ = value;
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x0600A308 RID: 41736 RVA: 0x00189FAB File Offset: 0x001881AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<bool> GmEntityFsmConditions
		{
			get
			{
				return this.gmEntityFsmConditions_;
			}
		}

		// Token: 0x0600A309 RID: 41737 RVA: 0x00189FB3 File Offset: 0x001881B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmEntityFsmTransitionInfo);
		}

		// Token: 0x0600A30A RID: 41738 RVA: 0x00189FC4 File Offset: 0x001881C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmEntityFsmTransitionInfo other)
		{
			return other != null && (other == this || (this.ToStateIndex == other.ToStateIndex && this.gmEntityFsmConditions_.Equals(other.gmEntityFsmConditions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x0018A014 File Offset: 0x00188214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ToStateIndex != 0)
			{
				num ^= this.ToStateIndex.GetHashCode();
			}
			num ^= this.gmEntityFsmConditions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A30C RID: 41740 RVA: 0x0018A061 File Offset: 0x00188261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A30D RID: 41741 RVA: 0x0018A06E File Offset: 0x0018826E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A30E RID: 41742 RVA: 0x0018A078 File Offset: 0x00188278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ToStateIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ToStateIndex);
			}
			this.gmEntityFsmConditions_.WriteTo(ref output, GmEntityFsmTransitionInfo._repeated_gmEntityFsmConditions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A30F RID: 41743 RVA: 0x0018A0C8 File Offset: 0x001882C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ToStateIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ToStateIndex);
			}
			num += this.gmEntityFsmConditions_.CalculateSize(GmEntityFsmTransitionInfo._repeated_gmEntityFsmConditions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A310 RID: 41744 RVA: 0x0018A11C File Offset: 0x0018831C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmEntityFsmTransitionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ToStateIndex != 0)
			{
				this.ToStateIndex = other.ToStateIndex;
			}
			this.gmEntityFsmConditions_.Add(other.gmEntityFsmConditions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x0018A169 File Offset: 0x00188369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A312 RID: 41746 RVA: 0x0018A174 File Offset: 0x00188374
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
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gmEntityFsmConditions_.AddEntriesFrom(ref input, GmEntityFsmTransitionInfo._repeated_gmEntityFsmConditions_codec);
					}
				}
				else
				{
					this.ToStateIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B6C RID: 19308
		private static readonly MessageParser<GmEntityFsmTransitionInfo> _parser = new MessageParser<GmEntityFsmTransitionInfo>(() => new GmEntityFsmTransitionInfo());

		// Token: 0x04004B6D RID: 19309
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B6E RID: 19310
		public const int ToStateIndexFieldNumber = 1;

		// Token: 0x04004B6F RID: 19311
		private int toStateIndex_;

		// Token: 0x04004B70 RID: 19312
		public const int GmEntityFsmConditionsFieldNumber = 2;

		// Token: 0x04004B71 RID: 19313
		private static readonly FieldCodec<bool> _repeated_gmEntityFsmConditions_codec = FieldCodec.ForBool(18U);

		// Token: 0x04004B72 RID: 19314
		private readonly RepeatedField<bool> gmEntityFsmConditions_ = new RepeatedField<bool>();
	}
}
