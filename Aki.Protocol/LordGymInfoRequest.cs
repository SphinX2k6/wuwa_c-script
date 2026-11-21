using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200094F RID: 2383
	[NetMessage(EMessageId.LordGymInfoRequest)]
	public sealed class LordGymInfoRequest : IMessage<LordGymInfoRequest>, IMessage, IEquatable<LordGymInfoRequest>, IDeepCloneable<LordGymInfoRequest>, IBufferMessage
	{
		// Token: 0x0600D259 RID: 53849 RVA: 0x001F0461 File Offset: 0x001EE661
		[NullableContext(1)]
		public static LordGymInfoRequest Create()
		{
			return new LordGymInfoRequest();
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x0600D25A RID: 53850 RVA: 0x001F0468 File Offset: 0x001EE668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x0600D25B RID: 53851 RVA: 0x001F046B File Offset: 0x001EE66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600D25C RID: 53852 RVA: 0x001F0472 File Offset: 0x001EE672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymInfoRequest()
		{
		}

		// Token: 0x0600D25D RID: 53853 RVA: 0x001F047A File Offset: 0x001EE67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymInfoRequest(LordGymInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D25E RID: 53854 RVA: 0x001F0493 File Offset: 0x001EE693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymInfoRequest Clone()
		{
			return new LordGymInfoRequest(this);
		}

		// Token: 0x0600D25F RID: 53855 RVA: 0x001F049B File Offset: 0x001EE69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymInfoRequest);
		}

		// Token: 0x0600D260 RID: 53856 RVA: 0x001F04A9 File Offset: 0x001EE6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D261 RID: 53857 RVA: 0x001F04C8 File Offset: 0x001EE6C8
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

		// Token: 0x0600D262 RID: 53858 RVA: 0x001F04EE File Offset: 0x001EE6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D263 RID: 53859 RVA: 0x001F04FB File Offset: 0x001EE6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D264 RID: 53860 RVA: 0x001F0504 File Offset: 0x001EE704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D265 RID: 53861 RVA: 0x001F051C File Offset: 0x001EE71C
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

		// Token: 0x0600D266 RID: 53862 RVA: 0x001F0542 File Offset: 0x001EE742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D267 RID: 53863 RVA: 0x001F055F File Offset: 0x001EE75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D268 RID: 53864 RVA: 0x001F0568 File Offset: 0x001EE768
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

		// Token: 0x040058E0 RID: 22752
		private UnknownFieldSet _unknownFields;
	}
}
