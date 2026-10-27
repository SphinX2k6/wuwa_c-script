using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001456 RID: 5206
	public sealed class TrapDefenseTechParam : IMessage<TrapDefenseTechParam>, IMessage, IEquatable<TrapDefenseTechParam>, IDeepCloneable<TrapDefenseTechParam>, IBufferMessage
	{
		// Token: 0x0601B91A RID: 112922 RVA: 0x003FDBC1 File Offset: 0x003FBDC1
		[NullableContext(1)]
		public static TrapDefenseTechParam Create()
		{
			return new TrapDefenseTechParam();
		}

		// Token: 0x17005CF7 RID: 23799
		// (get) Token: 0x0601B91B RID: 112923 RVA: 0x003FDBC8 File Offset: 0x003FBDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CF8 RID: 23800
		// (get) Token: 0x0601B91C RID: 112924 RVA: 0x003FDBCB File Offset: 0x003FBDCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTechParam.Descriptor;
			}
		}

		// Token: 0x0601B91D RID: 112925 RVA: 0x003FDBD2 File Offset: 0x003FBDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechParam()
		{
		}

		// Token: 0x0601B91E RID: 112926 RVA: 0x003FDBE5 File Offset: 0x003FBDE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechParam(TrapDefenseTechParam other) : this()
		{
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B91F RID: 112927 RVA: 0x003FDC0F File Offset: 0x003FBE0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechParam Clone()
		{
			return new TrapDefenseTechParam(this);
		}

		// Token: 0x17005CF9 RID: 23801
		// (get) Token: 0x0601B920 RID: 112928 RVA: 0x003FDC17 File Offset: 0x003FBE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x0601B921 RID: 112929 RVA: 0x003FDC1F File Offset: 0x003FBE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTechParam);
		}

		// Token: 0x0601B922 RID: 112930 RVA: 0x003FDC2D File Offset: 0x003FBE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTechParam other)
		{
			return other != null && (other == this || (this.Params.Equals(other.Params) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B923 RID: 112931 RVA: 0x003FDC60 File Offset: 0x003FBE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Params.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B924 RID: 112932 RVA: 0x003FDC94 File Offset: 0x003FBE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B925 RID: 112933 RVA: 0x003FDCA1 File Offset: 0x003FBEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B926 RID: 112934 RVA: 0x003FDCAA File Offset: 0x003FBEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.params_.WriteTo(ref output, TrapDefenseTechParam._map_params_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B927 RID: 112935 RVA: 0x003FDCD4 File Offset: 0x003FBED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.params_.CalculateSize(TrapDefenseTechParam._map_params_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B928 RID: 112936 RVA: 0x003FDD0D File Offset: 0x003FBF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseTechParam other)
		{
			if (other == null)
			{
				return;
			}
			this.params_.MergeFrom(other.params_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B929 RID: 112937 RVA: 0x003FDD3B File Offset: 0x003FBF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B92A RID: 112938 RVA: 0x003FDD44 File Offset: 0x003FBF44
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.params_.AddEntriesFrom(ref input, TrapDefenseTechParam._map_params_codec);
				}
			}
		}

		// Token: 0x04009EF2 RID: 40690
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EF3 RID: 40691
		public const int ParamsFieldNumber = 1;

		// Token: 0x04009EF4 RID: 40692
		private static readonly MapField<int, int>.Codec _map_params_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04009EF5 RID: 40693
		private readonly MapField<int, int> params_ = new MapField<int, int>();
	}
}
