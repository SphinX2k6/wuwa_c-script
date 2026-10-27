using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016B8 RID: 5816
	public sealed class Int2Bool : IMessage<Int2Bool>, IMessage, IEquatable<Int2Bool>, IDeepCloneable<Int2Bool>, IBufferMessage
	{
		// Token: 0x0601D22D RID: 119341 RVA: 0x00443161 File Offset: 0x00441361
		[NullableContext(1)]
		public static Int2Bool Create()
		{
			return new Int2Bool();
		}

		// Token: 0x170062D4 RID: 25300
		// (get) Token: 0x0601D22E RID: 119342 RVA: 0x00443168 File Offset: 0x00441368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Int2Bool> Parser
		{
			get
			{
				return Int2Bool._parser;
			}
		}

		// Token: 0x170062D5 RID: 25301
		// (get) Token: 0x0601D22F RID: 119343 RVA: 0x0044316F File Offset: 0x0044136F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062D6 RID: 25302
		// (get) Token: 0x0601D230 RID: 119344 RVA: 0x00443172 File Offset: 0x00441372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Int2Bool.Descriptor;
			}
		}

		// Token: 0x0601D231 RID: 119345 RVA: 0x00443179 File Offset: 0x00441379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int2Bool()
		{
		}

		// Token: 0x0601D232 RID: 119346 RVA: 0x00443181 File Offset: 0x00441381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int2Bool(Int2Bool other) : this()
		{
			this.first_ = other.first_;
			this.second_ = other.second_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D233 RID: 119347 RVA: 0x004431B2 File Offset: 0x004413B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int2Bool Clone()
		{
			return new Int2Bool(this);
		}

		// Token: 0x170062D7 RID: 25303
		// (get) Token: 0x0601D234 RID: 119348 RVA: 0x004431BA File Offset: 0x004413BA
		// (set) Token: 0x0601D235 RID: 119349 RVA: 0x004431C2 File Offset: 0x004413C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int First
		{
			get
			{
				return this.first_;
			}
			set
			{
				this.first_ = value;
			}
		}

		// Token: 0x170062D8 RID: 25304
		// (get) Token: 0x0601D236 RID: 119350 RVA: 0x004431CB File Offset: 0x004413CB
		// (set) Token: 0x0601D237 RID: 119351 RVA: 0x004431D3 File Offset: 0x004413D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Second
		{
			get
			{
				return this.second_;
			}
			set
			{
				this.second_ = value;
			}
		}

		// Token: 0x0601D238 RID: 119352 RVA: 0x004431DC File Offset: 0x004413DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Int2Bool);
		}

		// Token: 0x0601D239 RID: 119353 RVA: 0x004431EA File Offset: 0x004413EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Int2Bool other)
		{
			return other != null && (other == this || (this.First == other.First && this.Second == other.Second && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D23A RID: 119354 RVA: 0x00443228 File Offset: 0x00441428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.First != 0)
			{
				num ^= this.First.GetHashCode();
			}
			if (this.Second)
			{
				num ^= this.Second.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D23B RID: 119355 RVA: 0x00443280 File Offset: 0x00441480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D23C RID: 119356 RVA: 0x0044328D File Offset: 0x0044148D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D23D RID: 119357 RVA: 0x00443298 File Offset: 0x00441498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.First != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.First);
			}
			if (this.Second)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Second);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D23E RID: 119358 RVA: 0x004432F0 File Offset: 0x004414F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.First != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.First);
			}
			if (this.Second)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D23F RID: 119359 RVA: 0x0044333C File Offset: 0x0044153C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Int2Bool other)
		{
			if (other == null)
			{
				return;
			}
			if (other.First != 0)
			{
				this.First = other.First;
			}
			if (other.Second)
			{
				this.Second = other.Second;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D240 RID: 119360 RVA: 0x0044338C File Offset: 0x0044158C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D241 RID: 119361 RVA: 0x00443398 File Offset: 0x00441598
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
						this.Second = input.ReadBool();
					}
				}
				else
				{
					this.First = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400C466 RID: 50278
		private static readonly MessageParser<Int2Bool> _parser = new MessageParser<Int2Bool>(() => new Int2Bool());

		// Token: 0x0400C467 RID: 50279
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C468 RID: 50280
		public const int FirstFieldNumber = 1;

		// Token: 0x0400C469 RID: 50281
		private int first_;

		// Token: 0x0400C46A RID: 50282
		public const int SecondFieldNumber = 2;

		// Token: 0x0400C46B RID: 50283
		private bool second_;
	}
}
