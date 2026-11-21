using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000365 RID: 869
	[NetMessage(EMessageId.DangoBrawlInstPrepareNotify)]
	public sealed class DangoBrawlInstPrepareNotify : IMessage<DangoBrawlInstPrepareNotify>, IMessage, IEquatable<DangoBrawlInstPrepareNotify>, IDeepCloneable<DangoBrawlInstPrepareNotify>, IBufferMessage
	{
		// Token: 0x060056EB RID: 22251 RVA: 0x000D4BBA File Offset: 0x000D2DBA
		[NullableContext(1)]
		public static DangoBrawlInstPrepareNotify Create()
		{
			return new DangoBrawlInstPrepareNotify();
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x060056EC RID: 22252 RVA: 0x000D4BC1 File Offset: 0x000D2DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x060056ED RID: 22253 RVA: 0x000D4BC4 File Offset: 0x000D2DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlInstPrepareNotify.Descriptor;
			}
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x000D4BCB File Offset: 0x000D2DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstPrepareNotify()
		{
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x000D4BD3 File Offset: 0x000D2DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstPrepareNotify(DangoBrawlInstPrepareNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x000D4BEC File Offset: 0x000D2DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstPrepareNotify Clone()
		{
			return new DangoBrawlInstPrepareNotify(this);
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x000D4BF4 File Offset: 0x000D2DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlInstPrepareNotify);
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x000D4C02 File Offset: 0x000D2E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlInstPrepareNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x000D4C20 File Offset: 0x000D2E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x000D4C46 File Offset: 0x000D2E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x000D4C53 File Offset: 0x000D2E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x000D4C5C File Offset: 0x000D2E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056F7 RID: 22263 RVA: 0x000D4C74 File Offset: 0x000D2E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060056F8 RID: 22264 RVA: 0x000D4C9A File Offset: 0x000D2E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlInstPrepareNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060056F9 RID: 22265 RVA: 0x000D4CB7 File Offset: 0x000D2EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056FA RID: 22266 RVA: 0x000D4CC0 File Offset: 0x000D2EC0
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040034FD RID: 13565
		private UnknownFieldSet _unknownFields;
	}
}
