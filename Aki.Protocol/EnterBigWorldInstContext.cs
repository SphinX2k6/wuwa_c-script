using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200044F RID: 1103
	public sealed class EnterBigWorldInstContext : IMessage<EnterBigWorldInstContext>, IMessage, IEquatable<EnterBigWorldInstContext>, IDeepCloneable<EnterBigWorldInstContext>, IBufferMessage
	{
		// Token: 0x06006957 RID: 26967 RVA: 0x000FCB14 File Offset: 0x000FAD14
		[NullableContext(1)]
		public static EnterBigWorldInstContext Create()
		{
			return new EnterBigWorldInstContext();
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06006958 RID: 26968 RVA: 0x000FCB1B File Offset: 0x000FAD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06006959 RID: 26969 RVA: 0x000FCB1E File Offset: 0x000FAD1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterBigWorldInstContext.Descriptor;
			}
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x000FCB25 File Offset: 0x000FAD25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstContext()
		{
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x000FCB2D File Offset: 0x000FAD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstContext(EnterBigWorldInstContext other) : this()
		{
			if (other.EnterCtxCase == EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
			{
				this.SpringFestivalCtx = other.SpringFestivalCtx.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x000FCB60 File Offset: 0x000FAD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstContext Clone()
		{
			return new EnterBigWorldInstContext(this);
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x0600695D RID: 26973 RVA: 0x000FCB68 File Offset: 0x000FAD68
		// (set) Token: 0x0600695E RID: 26974 RVA: 0x000FCB80 File Offset: 0x000FAD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalCtx SpringFestivalCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
				{
					return null;
				}
				return (SpringFestivalCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterBigWorldInstContext.EnterCtxOneofCase.None : EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx);
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x0600695F RID: 26975 RVA: 0x000FCB96 File Offset: 0x000FAD96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstContext.EnterCtxOneofCase EnterCtxCase
		{
			get
			{
				return this.enterCtxCase_;
			}
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x000FCB9E File Offset: 0x000FAD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEnterCtx()
		{
			this.enterCtxCase_ = EnterBigWorldInstContext.EnterCtxOneofCase.None;
			this.enterCtx_ = null;
		}

		// Token: 0x06006961 RID: 26977 RVA: 0x000FCBAE File Offset: 0x000FADAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterBigWorldInstContext);
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x000FCBBC File Offset: 0x000FADBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterBigWorldInstContext other)
		{
			return other != null && (other == this || (object.Equals(this.SpringFestivalCtx, other.SpringFestivalCtx) && this.EnterCtxCase == other.EnterCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006963 RID: 26979 RVA: 0x000FCC0C File Offset: 0x000FAE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.enterCtxCase_ == EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
			{
				num ^= this.SpringFestivalCtx.GetHashCode();
			}
			num ^= (int)this.enterCtxCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x000FCC52 File Offset: 0x000FAE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x000FCC5F File Offset: 0x000FAE5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x000FCC68 File Offset: 0x000FAE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.enterCtxCase_ == EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SpringFestivalCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x000FCC9C File Offset: 0x000FAE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.enterCtxCase_ == EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpringFestivalCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x000FCCDC File Offset: 0x000FAEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterBigWorldInstContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EnterCtxCase == EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
			{
				if (this.SpringFestivalCtx == null)
				{
					this.SpringFestivalCtx = new SpringFestivalCtx();
				}
				this.SpringFestivalCtx.MergeFrom(other.SpringFestivalCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x000FCD31 File Offset: 0x000FAF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600696A RID: 26986 RVA: 0x000FCD3C File Offset: 0x000FAF3C
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
					SpringFestivalCtx springFestivalCtx = new SpringFestivalCtx();
					if (this.enterCtxCase_ == EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
					{
						springFestivalCtx.MergeFrom(this.SpringFestivalCtx);
					}
					input.ReadMessage(springFestivalCtx);
					this.SpringFestivalCtx = springFestivalCtx;
				}
			}
		}

		// Token: 0x040039EF RID: 14831
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039F0 RID: 14832
		public const int SpringFestivalCtxFieldNumber = 1;

		// Token: 0x040039F1 RID: 14833
		private object enterCtx_;

		// Token: 0x040039F2 RID: 14834
		private EnterBigWorldInstContext.EnterCtxOneofCase enterCtxCase_;

		// Token: 0x02001769 RID: 5993
		public enum EnterCtxOneofCase
		{
			// Token: 0x0400C5ED RID: 50669
			None,
			// Token: 0x0400C5EE RID: 50670
			SpringFestivalCtx
		}
	}
}
