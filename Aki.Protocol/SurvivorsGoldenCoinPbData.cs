using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001338 RID: 4920
	public sealed class SurvivorsGoldenCoinPbData : IMessage<SurvivorsGoldenCoinPbData>, IMessage, IEquatable<SurvivorsGoldenCoinPbData>, IDeepCloneable<SurvivorsGoldenCoinPbData>, IBufferMessage
	{
		// Token: 0x0601A3A3 RID: 107427 RVA: 0x003D2CC6 File Offset: 0x003D0EC6
		[NullableContext(1)]
		public static SurvivorsGoldenCoinPbData Create()
		{
			return new SurvivorsGoldenCoinPbData();
		}

		// Token: 0x170058D4 RID: 22740
		// (get) Token: 0x0601A3A4 RID: 107428 RVA: 0x003D2CCD File Offset: 0x003D0ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058D5 RID: 22741
		// (get) Token: 0x0601A3A5 RID: 107429 RVA: 0x003D2CD0 File Offset: 0x003D0ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsGoldenCoinPbData.Descriptor;
			}
		}

		// Token: 0x0601A3A6 RID: 107430 RVA: 0x003D2CD7 File Offset: 0x003D0ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinPbData()
		{
		}

		// Token: 0x0601A3A7 RID: 107431 RVA: 0x003D2CDF File Offset: 0x003D0EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinPbData(SurvivorsGoldenCoinPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A3A8 RID: 107432 RVA: 0x003D2CF8 File Offset: 0x003D0EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinPbData Clone()
		{
			return new SurvivorsGoldenCoinPbData(this);
		}

		// Token: 0x0601A3A9 RID: 107433 RVA: 0x003D2D00 File Offset: 0x003D0F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsGoldenCoinPbData);
		}

		// Token: 0x0601A3AA RID: 107434 RVA: 0x003D2D0E File Offset: 0x003D0F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsGoldenCoinPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A3AB RID: 107435 RVA: 0x003D2D2C File Offset: 0x003D0F2C
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

		// Token: 0x0601A3AC RID: 107436 RVA: 0x003D2D52 File Offset: 0x003D0F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A3AD RID: 107437 RVA: 0x003D2D5F File Offset: 0x003D0F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A3AE RID: 107438 RVA: 0x003D2D68 File Offset: 0x003D0F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A3AF RID: 107439 RVA: 0x003D2D80 File Offset: 0x003D0F80
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

		// Token: 0x0601A3B0 RID: 107440 RVA: 0x003D2DA6 File Offset: 0x003D0FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsGoldenCoinPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A3B1 RID: 107441 RVA: 0x003D2DC3 File Offset: 0x003D0FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A3B2 RID: 107442 RVA: 0x003D2DCC File Offset: 0x003D0FCC
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

		// Token: 0x04009A41 RID: 39489
		private UnknownFieldSet _unknownFields;
	}
}
