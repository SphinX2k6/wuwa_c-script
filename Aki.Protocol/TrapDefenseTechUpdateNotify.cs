using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200145A RID: 5210
	[NetMessage(EMessageId.TrapDefenseTechUpdateNotify)]
	public sealed class TrapDefenseTechUpdateNotify : IMessage<TrapDefenseTechUpdateNotify>, IMessage, IEquatable<TrapDefenseTechUpdateNotify>, IDeepCloneable<TrapDefenseTechUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B968 RID: 113000 RVA: 0x003FE559 File Offset: 0x003FC759
		[NullableContext(1)]
		public static TrapDefenseTechUpdateNotify Create()
		{
			return new TrapDefenseTechUpdateNotify();
		}

		// Token: 0x17005D06 RID: 23814
		// (get) Token: 0x0601B969 RID: 113001 RVA: 0x003FE560 File Offset: 0x003FC760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D07 RID: 23815
		// (get) Token: 0x0601B96A RID: 113002 RVA: 0x003FE563 File Offset: 0x003FC763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTechUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B96B RID: 113003 RVA: 0x003FE56A File Offset: 0x003FC76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUpdateNotify()
		{
		}

		// Token: 0x0601B96C RID: 113004 RVA: 0x003FE57D File Offset: 0x003FC77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUpdateNotify(TrapDefenseTechUpdateNotify other) : this()
		{
			this.unlockTechNodes_ = other.unlockTechNodes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B96D RID: 113005 RVA: 0x003FE5A7 File Offset: 0x003FC7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUpdateNotify Clone()
		{
			return new TrapDefenseTechUpdateNotify(this);
		}

		// Token: 0x17005D08 RID: 23816
		// (get) Token: 0x0601B96E RID: 113006 RVA: 0x003FE5AF File Offset: 0x003FC7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTechNodes
		{
			get
			{
				return this.unlockTechNodes_;
			}
		}

		// Token: 0x0601B96F RID: 113007 RVA: 0x003FE5B7 File Offset: 0x003FC7B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTechUpdateNotify);
		}

		// Token: 0x0601B970 RID: 113008 RVA: 0x003FE5C5 File Offset: 0x003FC7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTechUpdateNotify other)
		{
			return other != null && (other == this || (this.unlockTechNodes_.Equals(other.unlockTechNodes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B971 RID: 113009 RVA: 0x003FE5F8 File Offset: 0x003FC7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockTechNodes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B972 RID: 113010 RVA: 0x003FE62C File Offset: 0x003FC82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B973 RID: 113011 RVA: 0x003FE639 File Offset: 0x003FC839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B974 RID: 113012 RVA: 0x003FE642 File Offset: 0x003FC842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockTechNodes_.WriteTo(ref output, TrapDefenseTechUpdateNotify._repeated_unlockTechNodes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B975 RID: 113013 RVA: 0x003FE66C File Offset: 0x003FC86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockTechNodes_.CalculateSize(TrapDefenseTechUpdateNotify._repeated_unlockTechNodes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B976 RID: 113014 RVA: 0x003FE6A5 File Offset: 0x003FC8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseTechUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockTechNodes_.Add(other.unlockTechNodes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B977 RID: 113015 RVA: 0x003FE6D3 File Offset: 0x003FC8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B978 RID: 113016 RVA: 0x003FE6DC File Offset: 0x003FC8DC
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockTechNodes_.AddEntriesFrom(ref input, TrapDefenseTechUpdateNotify._repeated_unlockTechNodes_codec);
				}
			}
		}

		// Token: 0x04009F05 RID: 40709
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F06 RID: 40710
		public const int UnlockTechNodesFieldNumber = 1;

		// Token: 0x04009F07 RID: 40711
		private static readonly FieldCodec<int> _repeated_unlockTechNodes_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009F08 RID: 40712
		private readonly RepeatedField<int> unlockTechNodes_ = new RepeatedField<int>();
	}
}
