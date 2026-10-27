using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E58 RID: 3672
	public sealed class RacingBetsDestination : IMessage<RacingBetsDestination>, IMessage, IEquatable<RacingBetsDestination>, IDeepCloneable<RacingBetsDestination>, IBufferMessage
	{
		// Token: 0x06013B62 RID: 80738 RVA: 0x002DD69C File Offset: 0x002DB89C
		[NullableContext(1)]
		public static RacingBetsDestination Create()
		{
			return new RacingBetsDestination();
		}

		// Token: 0x1700416A RID: 16746
		// (get) Token: 0x06013B63 RID: 80739 RVA: 0x002DD6A3 File Offset: 0x002DB8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700416B RID: 16747
		// (get) Token: 0x06013B64 RID: 80740 RVA: 0x002DD6A6 File Offset: 0x002DB8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDestination.Descriptor;
			}
		}

		// Token: 0x06013B65 RID: 80741 RVA: 0x002DD6AD File Offset: 0x002DB8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDestination()
		{
		}

		// Token: 0x06013B66 RID: 80742 RVA: 0x002DD6B5 File Offset: 0x002DB8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDestination(RacingBetsDestination other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B67 RID: 80743 RVA: 0x002DD6DA File Offset: 0x002DB8DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDestination Clone()
		{
			return new RacingBetsDestination(this);
		}

		// Token: 0x1700416C RID: 16748
		// (get) Token: 0x06013B68 RID: 80744 RVA: 0x002DD6E2 File Offset: 0x002DB8E2
		// (set) Token: 0x06013B69 RID: 80745 RVA: 0x002DD6EA File Offset: 0x002DB8EA
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

		// Token: 0x06013B6A RID: 80746 RVA: 0x002DD6F3 File Offset: 0x002DB8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDestination);
		}

		// Token: 0x06013B6B RID: 80747 RVA: 0x002DD701 File Offset: 0x002DB901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDestination other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B6C RID: 80748 RVA: 0x002DD730 File Offset: 0x002DB930
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

		// Token: 0x06013B6D RID: 80749 RVA: 0x002DD76F File Offset: 0x002DB96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B6E RID: 80750 RVA: 0x002DD77C File Offset: 0x002DB97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B6F RID: 80751 RVA: 0x002DD785 File Offset: 0x002DB985
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

		// Token: 0x06013B70 RID: 80752 RVA: 0x002DD7B8 File Offset: 0x002DB9B8
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

		// Token: 0x06013B71 RID: 80753 RVA: 0x002DD7F6 File Offset: 0x002DB9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDestination other)
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

		// Token: 0x06013B72 RID: 80754 RVA: 0x002DD827 File Offset: 0x002DBA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B73 RID: 80755 RVA: 0x002DD830 File Offset: 0x002DBA30
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

		// Token: 0x0400788D RID: 30861
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400788E RID: 30862
		public const int DangoIdFieldNumber = 1;

		// Token: 0x0400788F RID: 30863
		private int dangoId_;
	}
}
