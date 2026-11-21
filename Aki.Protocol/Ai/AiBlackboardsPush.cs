using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001723 RID: 5923
	[NetMessage(EMessageId.AiBlackboardsPush)]
	public sealed class AiBlackboardsPush : IMessage<AiBlackboardsPush>, IMessage, IEquatable<AiBlackboardsPush>, IDeepCloneable<AiBlackboardsPush>, IBufferMessage
	{
		// Token: 0x0601DBBE RID: 121790 RVA: 0x0045CA19 File Offset: 0x0045AC19
		[NullableContext(1)]
		public static AiBlackboardsPush Create()
		{
			return new AiBlackboardsPush();
		}

		// Token: 0x1700653F RID: 25919
		// (get) Token: 0x0601DBBF RID: 121791 RVA: 0x0045CA20 File Offset: 0x0045AC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006540 RID: 25920
		// (get) Token: 0x0601DBC0 RID: 121792 RVA: 0x0045CA23 File Offset: 0x0045AC23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardsPush.Descriptor;
			}
		}

		// Token: 0x0601DBC1 RID: 121793 RVA: 0x0045CA2A File Offset: 0x0045AC2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsPush()
		{
		}

		// Token: 0x0601DBC2 RID: 121794 RVA: 0x0045CA3D File Offset: 0x0045AC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsPush(AiBlackboardsPush other) : this()
		{
			this.aiBlackboards_ = other.aiBlackboards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DBC3 RID: 121795 RVA: 0x0045CA67 File Offset: 0x0045AC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsPush Clone()
		{
			return new AiBlackboardsPush(this);
		}

		// Token: 0x17006541 RID: 25921
		// (get) Token: 0x0601DBC4 RID: 121796 RVA: 0x0045CA6F File Offset: 0x0045AC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> AiBlackboards
		{
			get
			{
				return this.aiBlackboards_;
			}
		}

		// Token: 0x0601DBC5 RID: 121797 RVA: 0x0045CA77 File Offset: 0x0045AC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardsPush);
		}

		// Token: 0x0601DBC6 RID: 121798 RVA: 0x0045CA85 File Offset: 0x0045AC85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardsPush other)
		{
			return other != null && (other == this || (this.aiBlackboards_.Equals(other.aiBlackboards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DBC7 RID: 121799 RVA: 0x0045CAB8 File Offset: 0x0045ACB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DBC8 RID: 121800 RVA: 0x0045CAEC File Offset: 0x0045ACEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DBC9 RID: 121801 RVA: 0x0045CAF9 File Offset: 0x0045ACF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DBCA RID: 121802 RVA: 0x0045CB02 File Offset: 0x0045AD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboards_.WriteTo(ref output, AiBlackboardsPush._repeated_aiBlackboards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DBCB RID: 121803 RVA: 0x0045CB2C File Offset: 0x0045AD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboards_.CalculateSize(AiBlackboardsPush._repeated_aiBlackboards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DBCC RID: 121804 RVA: 0x0045CB65 File Offset: 0x0045AD65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardsPush other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboards_.Add(other.aiBlackboards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DBCD RID: 121805 RVA: 0x0045CB93 File Offset: 0x0045AD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DBCE RID: 121806 RVA: 0x0045CB9C File Offset: 0x0045AD9C
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.aiBlackboards_.AddEntriesFrom(ref input, AiBlackboardsPush._repeated_aiBlackboards_codec);
				}
			}
		}

		// Token: 0x0400C94C RID: 51532
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C94D RID: 51533
		public const int AiBlackboardsFieldNumber = 3;

		// Token: 0x0400C94E RID: 51534
		private static readonly FieldCodec<BlackboardParam> _repeated_aiBlackboards_codec = FieldCodec.ForMessage<BlackboardParam>(26U, BlackboardParam.Parser);

		// Token: 0x0400C94F RID: 51535
		private readonly RepeatedField<BlackboardParam> aiBlackboards_ = new RepeatedField<BlackboardParam>();
	}
}
