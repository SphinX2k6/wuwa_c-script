using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F6 RID: 2294
	public sealed class LevelPlayDestroyActionCtxPb : IMessage<LevelPlayDestroyActionCtxPb>, IMessage, IEquatable<LevelPlayDestroyActionCtxPb>, IDeepCloneable<LevelPlayDestroyActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600CAC0 RID: 51904 RVA: 0x001DEC04 File Offset: 0x001DCE04
		[NullableContext(1)]
		public static LevelPlayDestroyActionCtxPb Create()
		{
			return new LevelPlayDestroyActionCtxPb();
		}

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x0600CAC1 RID: 51905 RVA: 0x001DEC0B File Offset: 0x001DCE0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x0600CAC2 RID: 51906 RVA: 0x001DEC0E File Offset: 0x001DCE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayDestroyActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600CAC3 RID: 51907 RVA: 0x001DEC15 File Offset: 0x001DCE15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayDestroyActionCtxPb()
		{
		}

		// Token: 0x0600CAC4 RID: 51908 RVA: 0x001DEC1D File Offset: 0x001DCE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayDestroyActionCtxPb(LevelPlayDestroyActionCtxPb other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CAC5 RID: 51909 RVA: 0x001DEC42 File Offset: 0x001DCE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayDestroyActionCtxPb Clone()
		{
			return new LevelPlayDestroyActionCtxPb(this);
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x0600CAC6 RID: 51910 RVA: 0x001DEC4A File Offset: 0x001DCE4A
		// (set) Token: 0x0600CAC7 RID: 51911 RVA: 0x001DEC52 File Offset: 0x001DCE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x0600CAC8 RID: 51912 RVA: 0x001DEC5B File Offset: 0x001DCE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayDestroyActionCtxPb);
		}

		// Token: 0x0600CAC9 RID: 51913 RVA: 0x001DEC69 File Offset: 0x001DCE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayDestroyActionCtxPb other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CACA RID: 51914 RVA: 0x001DEC98 File Offset: 0x001DCE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CACB RID: 51915 RVA: 0x001DECD7 File Offset: 0x001DCED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CACC RID: 51916 RVA: 0x001DECE4 File Offset: 0x001DCEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CACD RID: 51917 RVA: 0x001DECED File Offset: 0x001DCEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CACE RID: 51918 RVA: 0x001DED20 File Offset: 0x001DCF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CACF RID: 51919 RVA: 0x001DED5E File Offset: 0x001DCF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayDestroyActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CAD0 RID: 51920 RVA: 0x001DED8F File Offset: 0x001DCF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CAD1 RID: 51921 RVA: 0x001DED98 File Offset: 0x001DCF98
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
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400563A RID: 22074
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400563B RID: 22075
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x0400563C RID: 22076
		private int levelPlayId_;
	}
}
