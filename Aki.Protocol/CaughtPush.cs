using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200023D RID: 573
	[NetMessage(EMessageId.CaughtPush)]
	public sealed class CaughtPush : IMessage<CaughtPush>, IMessage, IEquatable<CaughtPush>, IDeepCloneable<CaughtPush>, IBufferMessage
	{
		// Token: 0x06003DB3 RID: 15795 RVA: 0x00098B80 File Offset: 0x00096D80
		[NullableContext(1)]
		public static CaughtPush Create()
		{
			return new CaughtPush();
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x00098B87 File Offset: 0x00096D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x00098B8A File Offset: 0x00096D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaughtPush.Descriptor;
			}
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x00098B91 File Offset: 0x00096D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtPush()
		{
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x00098B99 File Offset: 0x00096D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtPush(CaughtPush other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x00098BCE File Offset: 0x00096DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtPush Clone()
		{
			return new CaughtPush(this);
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x00098BD6 File Offset: 0x00096DD6
		// (set) Token: 0x06003DBA RID: 15802 RVA: 0x00098BDE File Offset: 0x00096DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00098BE7 File Offset: 0x00096DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaughtPush);
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x00098BF5 File Offset: 0x00096DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaughtPush other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x00098C28 File Offset: 0x00096E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x00098C64 File Offset: 0x00096E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x00098C71 File Offset: 0x00096E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x00098C7A File Offset: 0x00096E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x00098CAC File Offset: 0x00096EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00098CEC File Offset: 0x00096EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaughtPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new CaughtInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00098D40 File Offset: 0x00096F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x00098D4C File Offset: 0x00096F4C
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new CaughtInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04002CBD RID: 11453
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CBE RID: 11454
		public const int InfoFieldNumber = 13;

		// Token: 0x04002CBF RID: 11455
		private CaughtInfo info_;
	}
}
