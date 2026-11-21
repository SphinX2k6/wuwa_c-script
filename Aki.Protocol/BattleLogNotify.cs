using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200016B RID: 363
	[NetMessage(EMessageId.BattleLogNotify)]
	public sealed class BattleLogNotify : IMessage<BattleLogNotify>, IMessage, IEquatable<BattleLogNotify>, IDeepCloneable<BattleLogNotify>, IBufferMessage
	{
		// Token: 0x06002D31 RID: 11569 RVA: 0x00075813 File Offset: 0x00073A13
		[NullableContext(1)]
		public static BattleLogNotify Create()
		{
			return new BattleLogNotify();
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x0007581A File Offset: 0x00073A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x0007581D File Offset: 0x00073A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleLogNotify.Descriptor;
			}
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x00075824 File Offset: 0x00073A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleLogNotify()
		{
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x00075837 File Offset: 0x00073A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleLogNotify(BattleLogNotify other) : this()
		{
			this.log_ = other.log_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x0007585C File Offset: 0x00073A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleLogNotify Clone()
		{
			return new BattleLogNotify(this);
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x00075864 File Offset: 0x00073A64
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x0007586C File Offset: 0x00073A6C
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

		// Token: 0x06002D39 RID: 11577 RVA: 0x0007587F File Offset: 0x00073A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleLogNotify);
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x0007588D File Offset: 0x00073A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleLogNotify other)
		{
			return other != null && (other == this || (!(this.Log != other.Log) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x000758C0 File Offset: 0x00073AC0
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

		// Token: 0x06002D3C RID: 11580 RVA: 0x00075901 File Offset: 0x00073B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x0007590E File Offset: 0x00073B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x00075917 File Offset: 0x00073B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Log.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Log);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x00075950 File Offset: 0x00073B50
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

		// Token: 0x06002D40 RID: 11584 RVA: 0x00075993 File Offset: 0x00073B93
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

		// Token: 0x06002D41 RID: 11585 RVA: 0x000759C9 File Offset: 0x00073BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x000759D4 File Offset: 0x00073BD4
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Log = input.ReadString();
				}
			}
		}

		// Token: 0x04002883 RID: 10371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002884 RID: 10372
		public const int LogFieldNumber = 10;

		// Token: 0x04002885 RID: 10373
		private string log_ = "";
	}
}
