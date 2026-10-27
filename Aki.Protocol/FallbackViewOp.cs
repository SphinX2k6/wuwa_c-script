using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000519 RID: 1305
	public sealed class FallbackViewOp : IMessage<FallbackViewOp>, IMessage, IEquatable<FallbackViewOp>, IDeepCloneable<FallbackViewOp>, IBufferMessage
	{
		// Token: 0x06007AA5 RID: 31397 RVA: 0x00129D94 File Offset: 0x00127F94
		[NullableContext(1)]
		public static FallbackViewOp Create()
		{
			return new FallbackViewOp();
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06007AA6 RID: 31398 RVA: 0x00129D9B File Offset: 0x00127F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06007AA7 RID: 31399 RVA: 0x00129D9E File Offset: 0x00127F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FallbackViewOp.Descriptor;
			}
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x00129DA5 File Offset: 0x00127FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallbackViewOp()
		{
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x00129DAD File Offset: 0x00127FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallbackViewOp(FallbackViewOp other) : this()
		{
			this.showRestCount_ = other.showRestCount_;
			this.restCount_ = other.restCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AAA RID: 31402 RVA: 0x00129DDE File Offset: 0x00127FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallbackViewOp Clone()
		{
			return new FallbackViewOp(this);
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06007AAB RID: 31403 RVA: 0x00129DE6 File Offset: 0x00127FE6
		// (set) Token: 0x06007AAC RID: 31404 RVA: 0x00129DEE File Offset: 0x00127FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowRestCount
		{
			get
			{
				return this.showRestCount_;
			}
			set
			{
				this.showRestCount_ = value;
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06007AAD RID: 31405 RVA: 0x00129DF7 File Offset: 0x00127FF7
		// (set) Token: 0x06007AAE RID: 31406 RVA: 0x00129DFF File Offset: 0x00127FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RestCount
		{
			get
			{
				return this.restCount_;
			}
			set
			{
				this.restCount_ = value;
			}
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x00129E08 File Offset: 0x00128008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FallbackViewOp);
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x00129E16 File Offset: 0x00128016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FallbackViewOp other)
		{
			return other != null && (other == this || (this.ShowRestCount == other.ShowRestCount && this.RestCount == other.RestCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x00129E54 File Offset: 0x00128054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShowRestCount)
			{
				num ^= this.ShowRestCount.GetHashCode();
			}
			if (this.RestCount != 0)
			{
				num ^= this.RestCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007AB2 RID: 31410 RVA: 0x00129EAC File Offset: 0x001280AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007AB3 RID: 31411 RVA: 0x00129EB9 File Offset: 0x001280B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x00129EC4 File Offset: 0x001280C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowRestCount)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ShowRestCount);
			}
			if (this.RestCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RestCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x00129F1C File Offset: 0x0012811C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShowRestCount)
			{
				num += 2;
			}
			if (this.RestCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RestCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007AB6 RID: 31414 RVA: 0x00129F68 File Offset: 0x00128168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FallbackViewOp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShowRestCount)
			{
				this.ShowRestCount = other.ShowRestCount;
			}
			if (other.RestCount != 0)
			{
				this.RestCount = other.RestCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007AB7 RID: 31415 RVA: 0x00129FB8 File Offset: 0x001281B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007AB8 RID: 31416 RVA: 0x00129FC4 File Offset: 0x001281C4
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RestCount = input.ReadInt32();
					}
				}
				else
				{
					this.ShowRestCount = input.ReadBool();
				}
			}
		}

		// Token: 0x04003EF9 RID: 16121
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EFA RID: 16122
		public const int ShowRestCountFieldNumber = 1;

		// Token: 0x04003EFB RID: 16123
		private bool showRestCount_;

		// Token: 0x04003EFC RID: 16124
		public const int RestCountFieldNumber = 2;

		// Token: 0x04003EFD RID: 16125
		private int restCount_;
	}
}
