using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E57 RID: 3671
	public sealed class RacingBetsDangoRoundStart : IMessage<RacingBetsDangoRoundStart>, IMessage, IEquatable<RacingBetsDangoRoundStart>, IDeepCloneable<RacingBetsDangoRoundStart>, IBufferMessage
	{
		// Token: 0x06013B50 RID: 80720 RVA: 0x002DD4C2 File Offset: 0x002DB6C2
		[NullableContext(1)]
		public static RacingBetsDangoRoundStart Create()
		{
			return new RacingBetsDangoRoundStart();
		}

		// Token: 0x17004167 RID: 16743
		// (get) Token: 0x06013B51 RID: 80721 RVA: 0x002DD4C9 File Offset: 0x002DB6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004168 RID: 16744
		// (get) Token: 0x06013B52 RID: 80722 RVA: 0x002DD4CC File Offset: 0x002DB6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoRoundStart.Descriptor;
			}
		}

		// Token: 0x06013B53 RID: 80723 RVA: 0x002DD4D3 File Offset: 0x002DB6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoRoundStart()
		{
		}

		// Token: 0x06013B54 RID: 80724 RVA: 0x002DD4DB File Offset: 0x002DB6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoRoundStart(RacingBetsDangoRoundStart other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B55 RID: 80725 RVA: 0x002DD500 File Offset: 0x002DB700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoRoundStart Clone()
		{
			return new RacingBetsDangoRoundStart(this);
		}

		// Token: 0x17004169 RID: 16745
		// (get) Token: 0x06013B56 RID: 80726 RVA: 0x002DD508 File Offset: 0x002DB708
		// (set) Token: 0x06013B57 RID: 80727 RVA: 0x002DD510 File Offset: 0x002DB710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x06013B58 RID: 80728 RVA: 0x002DD519 File Offset: 0x002DB719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoRoundStart);
		}

		// Token: 0x06013B59 RID: 80729 RVA: 0x002DD527 File Offset: 0x002DB727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoRoundStart other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B5A RID: 80730 RVA: 0x002DD558 File Offset: 0x002DB758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013B5B RID: 80731 RVA: 0x002DD597 File Offset: 0x002DB797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B5C RID: 80732 RVA: 0x002DD5A4 File Offset: 0x002DB7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B5D RID: 80733 RVA: 0x002DD5AD File Offset: 0x002DB7AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013B5E RID: 80734 RVA: 0x002DD5E0 File Offset: 0x002DB7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013B5F RID: 80735 RVA: 0x002DD61E File Offset: 0x002DB81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDangoRoundStart other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013B60 RID: 80736 RVA: 0x002DD64F File Offset: 0x002DB84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B61 RID: 80737 RVA: 0x002DD658 File Offset: 0x002DB858
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DangoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400788A RID: 30858
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400788B RID: 30859
		public const int DangoIdFieldNumber = 1;

		// Token: 0x0400788C RID: 30860
		private int dangoId_;
	}
}
