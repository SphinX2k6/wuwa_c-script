using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200133B RID: 4923
	[NetMessage(EMessageId.SurvivorsLastInfoRequest)]
	public sealed class SurvivorsLastInfoRequest : IMessage<SurvivorsLastInfoRequest>, IMessage, IEquatable<SurvivorsLastInfoRequest>, IDeepCloneable<SurvivorsLastInfoRequest>, IBufferMessage
	{
		// Token: 0x0601A3E5 RID: 107493 RVA: 0x003D38D3 File Offset: 0x003D1AD3
		[NullableContext(1)]
		public static SurvivorsLastInfoRequest Create()
		{
			return new SurvivorsLastInfoRequest();
		}

		// Token: 0x170058E6 RID: 22758
		// (get) Token: 0x0601A3E6 RID: 107494 RVA: 0x003D38DA File Offset: 0x003D1ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058E7 RID: 22759
		// (get) Token: 0x0601A3E7 RID: 107495 RVA: 0x003D38DD File Offset: 0x003D1ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsLastInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601A3E8 RID: 107496 RVA: 0x003D38E4 File Offset: 0x003D1AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLastInfoRequest()
		{
		}

		// Token: 0x0601A3E9 RID: 107497 RVA: 0x003D38EC File Offset: 0x003D1AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLastInfoRequest(SurvivorsLastInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A3EA RID: 107498 RVA: 0x003D3905 File Offset: 0x003D1B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLastInfoRequest Clone()
		{
			return new SurvivorsLastInfoRequest(this);
		}

		// Token: 0x0601A3EB RID: 107499 RVA: 0x003D390D File Offset: 0x003D1B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsLastInfoRequest);
		}

		// Token: 0x0601A3EC RID: 107500 RVA: 0x003D391B File Offset: 0x003D1B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsLastInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A3ED RID: 107501 RVA: 0x003D393C File Offset: 0x003D1B3C
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

		// Token: 0x0601A3EE RID: 107502 RVA: 0x003D3962 File Offset: 0x003D1B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A3EF RID: 107503 RVA: 0x003D396F File Offset: 0x003D1B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A3F0 RID: 107504 RVA: 0x003D3978 File Offset: 0x003D1B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A3F1 RID: 107505 RVA: 0x003D3990 File Offset: 0x003D1B90
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

		// Token: 0x0601A3F2 RID: 107506 RVA: 0x003D39B6 File Offset: 0x003D1BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsLastInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A3F3 RID: 107507 RVA: 0x003D39D3 File Offset: 0x003D1BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A3F4 RID: 107508 RVA: 0x003D39DC File Offset: 0x003D1BDC
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

		// Token: 0x04009A64 RID: 39524
		private UnknownFieldSet _unknownFields;
	}
}
