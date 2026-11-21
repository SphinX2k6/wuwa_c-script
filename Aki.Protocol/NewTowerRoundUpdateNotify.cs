using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B37 RID: 2871
	[NetMessage(EMessageId.NewTowerRoundUpdateNotify)]
	public sealed class NewTowerRoundUpdateNotify : IMessage<NewTowerRoundUpdateNotify>, IMessage, IEquatable<NewTowerRoundUpdateNotify>, IDeepCloneable<NewTowerRoundUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F971 RID: 63857 RVA: 0x002465EC File Offset: 0x002447EC
		[NullableContext(1)]
		public static NewTowerRoundUpdateNotify Create()
		{
			return new NewTowerRoundUpdateNotify();
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0600F972 RID: 63858 RVA: 0x002465F3 File Offset: 0x002447F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x0600F973 RID: 63859 RVA: 0x002465F6 File Offset: 0x002447F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRoundUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F974 RID: 63860 RVA: 0x002465FD File Offset: 0x002447FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoundUpdateNotify()
		{
		}

		// Token: 0x0600F975 RID: 63861 RVA: 0x00246605 File Offset: 0x00244805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoundUpdateNotify(NewTowerRoundUpdateNotify other) : this()
		{
			this.round_ = other.round_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F976 RID: 63862 RVA: 0x0024662A File Offset: 0x0024482A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoundUpdateNotify Clone()
		{
			return new NewTowerRoundUpdateNotify(this);
		}

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x0600F977 RID: 63863 RVA: 0x00246632 File Offset: 0x00244832
		// (set) Token: 0x0600F978 RID: 63864 RVA: 0x0024663A File Offset: 0x0024483A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Round
		{
			get
			{
				return this.round_;
			}
			set
			{
				this.round_ = value;
			}
		}

		// Token: 0x0600F979 RID: 63865 RVA: 0x00246643 File Offset: 0x00244843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRoundUpdateNotify);
		}

		// Token: 0x0600F97A RID: 63866 RVA: 0x00246651 File Offset: 0x00244851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRoundUpdateNotify other)
		{
			return other != null && (other == this || (this.Round == other.Round && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F97B RID: 63867 RVA: 0x00246680 File Offset: 0x00244880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Round != 0)
			{
				num ^= this.Round.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F97C RID: 63868 RVA: 0x002466BF File Offset: 0x002448BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F97D RID: 63869 RVA: 0x002466CC File Offset: 0x002448CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F97E RID: 63870 RVA: 0x002466D5 File Offset: 0x002448D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Round != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Round);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F97F RID: 63871 RVA: 0x00246708 File Offset: 0x00244908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Round != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Round);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F980 RID: 63872 RVA: 0x00246746 File Offset: 0x00244946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRoundUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Round != 0)
			{
				this.Round = other.Round;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F981 RID: 63873 RVA: 0x00246777 File Offset: 0x00244977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F982 RID: 63874 RVA: 0x00246780 File Offset: 0x00244980
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Round = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006455 RID: 25685
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006456 RID: 25686
		public const int RoundFieldNumber = 5;

		// Token: 0x04006457 RID: 25687
		private int round_;
	}
}
