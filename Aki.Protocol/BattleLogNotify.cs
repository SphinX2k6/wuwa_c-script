using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000168 RID: 360
	[NetMessage(EMessageId.BattleLogNotify)]
	public sealed class BattleLogNotify : IMessage<BattleLogNotify>, IMessage, IEquatable<BattleLogNotify>, IDeepCloneable<BattleLogNotify>, IBufferMessage
	{
		// Token: 0x06002CBA RID: 11450 RVA: 0x000743DF File Offset: 0x000725DF
		[NullableContext(1)]
		public static BattleLogNotify Create()
		{
			return new BattleLogNotify();
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x000743E6 File Offset: 0x000725E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002CBC RID: 11452 RVA: 0x000743E9 File Offset: 0x000725E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleLogNotify.Descriptor;
			}
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x000743F0 File Offset: 0x000725F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleLogNotify()
		{
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x00074403 File Offset: 0x00072603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleLogNotify(BattleLogNotify other) : this()
		{
			this.log_ = other.log_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x00074428 File Offset: 0x00072628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleLogNotify Clone()
		{
			return new BattleLogNotify(this);
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x00074430 File Offset: 0x00072630
		// (set) Token: 0x06002CC1 RID: 11457 RVA: 0x00074438 File Offset: 0x00072638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Log
		{
			get
			{
				return this.log_;
			}
			set
			{
				this.log_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x0007444B File Offset: 0x0007264B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleLogNotify);
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x00074459 File Offset: 0x00072659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleLogNotify other)
		{
			return other != null && (other == this || (!(this.Log != other.Log) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x0007448C File Offset: 0x0007268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Log.Length != 0)
			{
				num ^= this.Log.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x000744CD File Offset: 0x000726CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x000744DA File Offset: 0x000726DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x000744E3 File Offset: 0x000726E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Log.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Log);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x0007451C File Offset: 0x0007271C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Log.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Log);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x0007455F File Offset: 0x0007275F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleLogNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Log.Length != 0)
			{
				this.Log = other.Log;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x00074595 File Offset: 0x00072795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x000745A0 File Offset: 0x000727A0
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Log = input.ReadString();
				}
			}
		}

		// Token: 0x0400280F RID: 10255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002810 RID: 10256
		public const int LogFieldNumber = 2;

		// Token: 0x04002811 RID: 10257
		private string log_ = "";
	}
}
