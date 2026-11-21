using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200135D RID: 4957
	public sealed class SurvivorsToken : IMessage<SurvivorsToken>, IMessage, IEquatable<SurvivorsToken>, IDeepCloneable<SurvivorsToken>, IBufferMessage
	{
		// Token: 0x0601A684 RID: 108164 RVA: 0x003D9428 File Offset: 0x003D7628
		[NullableContext(1)]
		public static SurvivorsToken Create()
		{
			return new SurvivorsToken();
		}

		// Token: 0x1700596B RID: 22891
		// (get) Token: 0x0601A685 RID: 108165 RVA: 0x003D942F File Offset: 0x003D762F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700596C RID: 22892
		// (get) Token: 0x0601A686 RID: 108166 RVA: 0x003D9432 File Offset: 0x003D7632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsToken.Descriptor;
			}
		}

		// Token: 0x0601A687 RID: 108167 RVA: 0x003D9439 File Offset: 0x003D7639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsToken()
		{
		}

		// Token: 0x0601A688 RID: 108168 RVA: 0x003D9441 File Offset: 0x003D7641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsToken(SurvivorsToken other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A689 RID: 108169 RVA: 0x003D945A File Offset: 0x003D765A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsToken Clone()
		{
			return new SurvivorsToken(this);
		}

		// Token: 0x0601A68A RID: 108170 RVA: 0x003D9462 File Offset: 0x003D7662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsToken);
		}

		// Token: 0x0601A68B RID: 108171 RVA: 0x003D9470 File Offset: 0x003D7670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsToken other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A68C RID: 108172 RVA: 0x003D9490 File Offset: 0x003D7690
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

		// Token: 0x0601A68D RID: 108173 RVA: 0x003D94B6 File Offset: 0x003D76B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A68E RID: 108174 RVA: 0x003D94C3 File Offset: 0x003D76C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A68F RID: 108175 RVA: 0x003D94CC File Offset: 0x003D76CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A690 RID: 108176 RVA: 0x003D94E4 File Offset: 0x003D76E4
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

		// Token: 0x0601A691 RID: 108177 RVA: 0x003D950A File Offset: 0x003D770A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsToken other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A692 RID: 108178 RVA: 0x003D9527 File Offset: 0x003D7727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A693 RID: 108179 RVA: 0x003D9530 File Offset: 0x003D7730
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

		// Token: 0x04009B01 RID: 39681
		private UnknownFieldSet _unknownFields;
	}
}
