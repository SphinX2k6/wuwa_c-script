using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001491 RID: 5265
	[NetMessage(EMessageId.TrapDefenseCurChallengeInfoRequest)]
	public sealed class TrapDefenseCurChallengeInfoRequest : IMessage<TrapDefenseCurChallengeInfoRequest>, IMessage, IEquatable<TrapDefenseCurChallengeInfoRequest>, IDeepCloneable<TrapDefenseCurChallengeInfoRequest>, IBufferMessage
	{
		// Token: 0x0601BF4F RID: 114511 RVA: 0x0040FDC7 File Offset: 0x0040DFC7
		[NullableContext(1)]
		public static TrapDefenseCurChallengeInfoRequest Create()
		{
			return new TrapDefenseCurChallengeInfoRequest();
		}

		// Token: 0x17005EAB RID: 24235
		// (get) Token: 0x0601BF50 RID: 114512 RVA: 0x0040FDCE File Offset: 0x0040DFCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EAC RID: 24236
		// (get) Token: 0x0601BF51 RID: 114513 RVA: 0x0040FDD1 File Offset: 0x0040DFD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseCurChallengeInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601BF52 RID: 114514 RVA: 0x0040FDD8 File Offset: 0x0040DFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCurChallengeInfoRequest()
		{
		}

		// Token: 0x0601BF53 RID: 114515 RVA: 0x0040FDE0 File Offset: 0x0040DFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCurChallengeInfoRequest(TrapDefenseCurChallengeInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF54 RID: 114516 RVA: 0x0040FDF9 File Offset: 0x0040DFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCurChallengeInfoRequest Clone()
		{
			return new TrapDefenseCurChallengeInfoRequest(this);
		}

		// Token: 0x0601BF55 RID: 114517 RVA: 0x0040FE01 File Offset: 0x0040E001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseCurChallengeInfoRequest);
		}

		// Token: 0x0601BF56 RID: 114518 RVA: 0x0040FE0F File Offset: 0x0040E00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseCurChallengeInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601BF57 RID: 114519 RVA: 0x0040FE30 File Offset: 0x0040E030
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

		// Token: 0x0601BF58 RID: 114520 RVA: 0x0040FE56 File Offset: 0x0040E056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF59 RID: 114521 RVA: 0x0040FE63 File Offset: 0x0040E063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF5A RID: 114522 RVA: 0x0040FE6C File Offset: 0x0040E06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF5B RID: 114523 RVA: 0x0040FE84 File Offset: 0x0040E084
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

		// Token: 0x0601BF5C RID: 114524 RVA: 0x0040FEAA File Offset: 0x0040E0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseCurChallengeInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF5D RID: 114525 RVA: 0x0040FEC7 File Offset: 0x0040E0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF5E RID: 114526 RVA: 0x0040FED0 File Offset: 0x0040E0D0
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

		// Token: 0x0400A213 RID: 41491
		private UnknownFieldSet _unknownFields;
	}
}
