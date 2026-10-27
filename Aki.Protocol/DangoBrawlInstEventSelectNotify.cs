using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200035C RID: 860
	[NetMessage(EMessageId.DangoBrawlInstEventSelectNotify)]
	public sealed class DangoBrawlInstEventSelectNotify : IMessage<DangoBrawlInstEventSelectNotify>, IMessage, IEquatable<DangoBrawlInstEventSelectNotify>, IDeepCloneable<DangoBrawlInstEventSelectNotify>, IBufferMessage
	{
		// Token: 0x060055EE RID: 21998 RVA: 0x000D23F5 File Offset: 0x000D05F5
		[NullableContext(1)]
		public static DangoBrawlInstEventSelectNotify Create()
		{
			return new DangoBrawlInstEventSelectNotify();
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x060055EF RID: 21999 RVA: 0x000D23FC File Offset: 0x000D05FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x060055F0 RID: 22000 RVA: 0x000D23FF File Offset: 0x000D05FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlInstEventSelectNotify.Descriptor;
			}
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x000D2406 File Offset: 0x000D0606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstEventSelectNotify()
		{
		}

		// Token: 0x060055F2 RID: 22002 RVA: 0x000D240E File Offset: 0x000D060E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstEventSelectNotify(DangoBrawlInstEventSelectNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x000D2427 File Offset: 0x000D0627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstEventSelectNotify Clone()
		{
			return new DangoBrawlInstEventSelectNotify(this);
		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x000D242F File Offset: 0x000D062F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlInstEventSelectNotify);
		}

		// Token: 0x060055F5 RID: 22005 RVA: 0x000D243D File Offset: 0x000D063D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlInstEventSelectNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x000D245C File Offset: 0x000D065C
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

		// Token: 0x060055F7 RID: 22007 RVA: 0x000D2482 File Offset: 0x000D0682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x000D248F File Offset: 0x000D068F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x000D2498 File Offset: 0x000D0698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x000D24B0 File Offset: 0x000D06B0
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

		// Token: 0x060055FB RID: 22011 RVA: 0x000D24D6 File Offset: 0x000D06D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlInstEventSelectNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x000D24F3 File Offset: 0x000D06F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060055FD RID: 22013 RVA: 0x000D24FC File Offset: 0x000D06FC
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

		// Token: 0x04003460 RID: 13408
		private UnknownFieldSet _unknownFields;
	}
}
