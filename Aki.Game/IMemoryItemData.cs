using System;
using System.Runtime.CompilerServices;

// Token: 0x02001342 RID: 4930
[NullableContext(2)]
public interface IMemoryItemData
{
	// Token: 0x17000BA7 RID: 2983
	// (get) Token: 0x06008927 RID: 35111
	// (set) Token: 0x06008928 RID: 35112
	EMemoryContentId Type { get; set; }

	// Token: 0x17000BA8 RID: 2984
	// (get) Token: 0x06008929 RID: 35113
	// (set) Token: 0x0600892A RID: 35114
	EMemoryClassify Classify { get; set; }

	// Token: 0x17000BA9 RID: 2985
	// (get) Token: 0x0600892B RID: 35115
	// (set) Token: 0x0600892C RID: 35116
	[Nullable(1)]
	string Title { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000BAA RID: 2986
	// (get) Token: 0x0600892D RID: 35117
	// (set) Token: 0x0600892E RID: 35118
	bool HasData { get; set; }

	// Token: 0x17000BAB RID: 2987
	// (get) Token: 0x0600892F RID: 35119
	// (set) Token: 0x06008930 RID: 35120
	bool IsDelegate { get; set; }

	// Token: 0x17000BAC RID: 2988
	// (get) Token: 0x06008931 RID: 35121
	// (set) Token: 0x06008932 RID: 35122
	int Sort { get; set; }

	// Token: 0x17000BAD RID: 2989
	// (get) Token: 0x06008933 RID: 35123
	// (set) Token: 0x06008934 RID: 35124
	string Content { get; set; }

	// Token: 0x17000BAE RID: 2990
	// (get) Token: 0x06008935 RID: 35125
	// (set) Token: 0x06008936 RID: 35126
	string SubContent { get; set; }

	// Token: 0x17000BAF RID: 2991
	// (get) Token: 0x06008937 RID: 35127
	// (set) Token: 0x06008938 RID: 35128
	string IconPath { get; set; }
}
